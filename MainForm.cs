using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_Csharp_Winform_2
{
	public partial class MainForm : Form
	{
		Random random = new Random(37);
		public MainForm()
		{
			InitializeComponent();

			// lvDummy에 칼럼을 생성하는 코드 
			lvDummy.Columns.Add("Name");
			lvDummy.Columns.Add("Depth");
		}

		void ChangeFont()
		{
			if (cboFont.SelectedIndex < 0)      // cboFont에서 선택한 항목이 없으면 메소드 종료
				return;

			FontStyle style = FontStyle.Regular;        // FontStyle 객체 초기화


			// 굵게와 이탤릭은 동시 적용이 가능하므로 논리합으로 진행해야한다.
			if (chkBold.Checked)    // 굵게 체크박스가 선택되어있으면 Bold논리합 수행
				style |= FontStyle.Bold;

			if (chkItalic.Checked)    //	이탤릭 체크박스가 선택되어있으면 Italic논리합 수행
				style |= FontStyle.Italic;


			txtSampleText.Font =    // txtSampleText의 Font프로퍼티를 앞에서 만든 style로 수정
				new Font((string)cboFont.SelectedItem, 10, style);
		}

		private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			// 컨트롤박스에서 선택된게 변화가 생기면 실행
			ChangeFont();
		}

		private void chkItalic_CheckedChanged(object sender, EventArgs e)
		{
			// 체크박스 체크상태에 변화생기면 실행
			ChangeFont();
		}

		private void chkBold_CheckedChanged(object sender, EventArgs e)
		{
			// 체크박스 체크상태에 변화생기면 실행
			ChangeFont();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var Fonts = FontFamily.Families;            // 운영체제에 설치되있는 폰트목록검색

			foreach (FontFamily font in Fonts)          // cboFont 컨트롤에 각 폰트 이름 추가
				cboFont.Items.Add(font.Name);
		}

		private void tbDummy_Scroll(object sender, EventArgs e)
		{
			// 트랙바를 슬라이드할때 실행
			pgDummy.Value = tbDummy.Value;	// 슬라이더의 위치에 따라 프로그레스바의 내용도 변경
		}

		private void btnModal_Click(object sender, EventArgs e)
		{
			Form frm = new Form();
			frm.Text = "Modal Form";
			frm.Width = 300;
			frm.Height = 100;
			frm.BackColor = Color.Red;
			frm.ShowDialog();				// Modal창을 띄웁니다.
		}

		private void btnModaless_Click(object sender, EventArgs e)
		{
			Form frm = new Form();
			frm.Text = "Modaless Form";
			frm.Width = 300;
			frm.Height = 300;
			frm.BackColor = Color.Green;
			frm.Show();						// Modaless창을 띄웁니다.
		}

		private void btnMsgBox_Click(object sender, EventArgs e)
		{
			// MessageBox를 띄웁니다.
			MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			//					메세지박스내용		타이틀			메세지박스 버튼추가		메세지박스 아이콘 추가
		}

		void TreeToList()
		{
			// TreeView의 각 노드를 ListView로 옮겨 표시하는 기능
			lvDummy.Items.Clear();						// 리스트뷰 내용 초기화
			foreach (TreeNode node in tvDummy.Nodes)    // 트리뷰의 각각의 루트노드들에 TreeToList(node) 수행
				TreeToList(node);
		}

		void TreeToList(TreeNode Node)
		{
			// TreeView의 각 노드를 ListView로 옮겨 표시
			lvDummy.Items.Add(
				new ListViewItem(
					new string[] { Node.Text, Node.FullPath.Count(f => f == '\\').ToString() }
					)	//			Name			Depth			
				);
			// TreeNode형식의 FullPath 프로퍼티는 루트노드부터 현재노드까지의 경로를 나타낸다.
			// 이때 각 경로는 '\\'로 구분된다. 즉, 이 갯수를 세는 것으로 깊이(Depth)를 카운팅
			// 루트 = 0

			foreach(TreeNode node in Node.Nodes)
			{
				// 현재의 노드의 자식노드들에 대해서도 같은 일을 반복
				TreeToList(node);
			}
		}

		private void btnAddRoot_Click(object sender, EventArgs e)
		{
			tvDummy.Nodes.Add(random.Next().ToString());
			TreeToList();
		}

		private void btnAddChild_Click(object sender, EventArgs e)
		{
			if(tvDummy.SelectedNode == null)
			{
				MessageBox.Show("선택된 노드가 없습니다.", "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
			tvDummy.SelectedNode.Expand();
			TreeToList();
		}
	}
}
