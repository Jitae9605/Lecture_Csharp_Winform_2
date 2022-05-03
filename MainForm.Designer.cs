
namespace Lecture_Csharp_Winform_2
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.IbIFont = new System.Windows.Forms.Label();
			this.grpFont = new System.Windows.Forms.GroupBox();
			this.txtSampleText = new System.Windows.Forms.TextBox();
			this.cboFont = new System.Windows.Forms.ComboBox();
			this.chkItalic = new System.Windows.Forms.CheckBox();
			this.chkBold = new System.Windows.Forms.CheckBox();
			this.grpBar = new System.Windows.Forms.GroupBox();
			this.pgDummy = new System.Windows.Forms.ProgressBar();
			this.tbDummy = new System.Windows.Forms.TrackBar();
			this.btnModal = new System.Windows.Forms.Button();
			this.btnModaless = new System.Windows.Forms.Button();
			this.btnMsgBox = new System.Windows.Forms.Button();
			this.grpTreeList = new System.Windows.Forms.GroupBox();
			this.lvDummy = new System.Windows.Forms.ListView();
			this.tvDummy = new System.Windows.Forms.TreeView();
			this.btnAddChild = new System.Windows.Forms.Button();
			this.btnAddRoot = new System.Windows.Forms.Button();
			this.grpFont.SuspendLayout();
			this.grpBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
			this.grpTreeList.SuspendLayout();
			this.SuspendLayout();
			// 
			// IbIFont
			// 
			this.IbIFont.AutoSize = true;
			this.IbIFont.Location = new System.Drawing.Point(40, 58);
			this.IbIFont.Name = "IbIFont";
			this.IbIFont.Size = new System.Drawing.Size(41, 12);
			this.IbIFont.TabIndex = 0;
			this.IbIFont.Text = "Font : ";
			// 
			// grpFont
			// 
			this.grpFont.Controls.Add(this.txtSampleText);
			this.grpFont.Controls.Add(this.cboFont);
			this.grpFont.Controls.Add(this.chkItalic);
			this.grpFont.Controls.Add(this.chkBold);
			this.grpFont.Controls.Add(this.IbIFont);
			this.grpFont.Location = new System.Drawing.Point(27, 12);
			this.grpFont.Name = "grpFont";
			this.grpFont.Size = new System.Drawing.Size(441, 175);
			this.grpFont.TabIndex = 1;
			this.grpFont.TabStop = false;
			this.grpFont.Text = "CombBoX, CheckBox, TextBox";
			// 
			// txtSampleText
			// 
			this.txtSampleText.Location = new System.Drawing.Point(42, 96);
			this.txtSampleText.Name = "txtSampleText";
			this.txtSampleText.Size = new System.Drawing.Size(301, 21);
			this.txtSampleText.TabIndex = 2;
			this.txtSampleText.Text = "Hello, C#";
			// 
			// cboFont
			// 
			this.cboFont.FormattingEnabled = true;
			this.cboFont.Location = new System.Drawing.Point(87, 55);
			this.cboFont.Name = "cboFont";
			this.cboFont.Size = new System.Drawing.Size(121, 20);
			this.cboFont.TabIndex = 2;
			this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
			// 
			// chkItalic
			// 
			this.chkItalic.AutoSize = true;
			this.chkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.chkItalic.Location = new System.Drawing.Point(283, 57);
			this.chkItalic.Name = "chkItalic";
			this.chkItalic.Size = new System.Drawing.Size(60, 16);
			this.chkItalic.TabIndex = 1;
			this.chkItalic.Text = "이탤릭";
			this.chkItalic.UseVisualStyleBackColor = true;
			this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
			// 
			// chkBold
			// 
			this.chkBold.AutoSize = true;
			this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.chkBold.Location = new System.Drawing.Point(227, 57);
			this.chkBold.Name = "chkBold";
			this.chkBold.Size = new System.Drawing.Size(50, 16);
			this.chkBold.TabIndex = 1;
			this.chkBold.Text = "굵게";
			this.chkBold.UseVisualStyleBackColor = true;
			this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
			// 
			// grpBar
			// 
			this.grpBar.Controls.Add(this.pgDummy);
			this.grpBar.Controls.Add(this.tbDummy);
			this.grpBar.Location = new System.Drawing.Point(27, 193);
			this.grpBar.Name = "grpBar";
			this.grpBar.Size = new System.Drawing.Size(441, 150);
			this.grpBar.TabIndex = 2;
			this.grpBar.TabStop = false;
			this.grpBar.Text = "TrackBar && ProgressBar";
			// 
			// pgDummy
			// 
			this.pgDummy.Location = new System.Drawing.Point(15, 93);
			this.pgDummy.Maximum = 20;
			this.pgDummy.Name = "pgDummy";
			this.pgDummy.Size = new System.Drawing.Size(406, 24);
			this.pgDummy.TabIndex = 1;
			// 
			// tbDummy
			// 
			this.tbDummy.Location = new System.Drawing.Point(15, 32);
			this.tbDummy.Maximum = 20;
			this.tbDummy.Name = "tbDummy";
			this.tbDummy.Size = new System.Drawing.Size(406, 45);
			this.tbDummy.TabIndex = 0;
			this.tbDummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
			// 
			// btnModal
			// 
			this.btnModal.Location = new System.Drawing.Point(63, 349);
			this.btnModal.Name = "btnModal";
			this.btnModal.Size = new System.Drawing.Size(96, 39);
			this.btnModal.TabIndex = 3;
			this.btnModal.Text = "Modal";
			this.btnModal.UseVisualStyleBackColor = true;
			this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
			// 
			// btnModaless
			// 
			this.btnModaless.Location = new System.Drawing.Point(182, 349);
			this.btnModaless.Name = "btnModaless";
			this.btnModaless.Size = new System.Drawing.Size(96, 39);
			this.btnModaless.TabIndex = 3;
			this.btnModaless.Text = "Modaless";
			this.btnModaless.UseVisualStyleBackColor = true;
			this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
			// 
			// btnMsgBox
			// 
			this.btnMsgBox.Location = new System.Drawing.Point(304, 349);
			this.btnMsgBox.Name = "btnMsgBox";
			this.btnMsgBox.Size = new System.Drawing.Size(96, 39);
			this.btnMsgBox.TabIndex = 3;
			this.btnMsgBox.Text = "MessageBox";
			this.btnMsgBox.UseVisualStyleBackColor = true;
			this.btnMsgBox.Click += new System.EventHandler(this.btnMsgBox_Click);
			// 
			// grpTreeList
			// 
			this.grpTreeList.Controls.Add(this.lvDummy);
			this.grpTreeList.Controls.Add(this.tvDummy);
			this.grpTreeList.Controls.Add(this.btnAddChild);
			this.grpTreeList.Controls.Add(this.btnAddRoot);
			this.grpTreeList.Location = new System.Drawing.Point(27, 394);
			this.grpTreeList.Name = "grpTreeList";
			this.grpTreeList.Size = new System.Drawing.Size(441, 227);
			this.grpTreeList.TabIndex = 4;
			this.grpTreeList.TabStop = false;
			this.grpTreeList.Text = "TreeView && ListView";
			// 
			// lvDummy
			// 
			this.lvDummy.HideSelection = false;
			this.lvDummy.Location = new System.Drawing.Point(227, 20);
			this.lvDummy.Name = "lvDummy";
			this.lvDummy.Size = new System.Drawing.Size(194, 192);
			this.lvDummy.TabIndex = 5;
			this.lvDummy.UseCompatibleStateImageBehavior = false;
			this.lvDummy.View = System.Windows.Forms.View.Details;
			// 
			// tvDummy
			// 
			this.tvDummy.Location = new System.Drawing.Point(15, 20);
			this.tvDummy.Name = "tvDummy";
			this.tvDummy.Size = new System.Drawing.Size(206, 163);
			this.tvDummy.TabIndex = 6;
			// 
			// btnAddChild
			// 
			this.btnAddChild.Location = new System.Drawing.Point(133, 189);
			this.btnAddChild.Name = "btnAddChild";
			this.btnAddChild.Size = new System.Drawing.Size(75, 23);
			this.btnAddChild.TabIndex = 5;
			this.btnAddChild.Text = "자식추가";
			this.btnAddChild.UseVisualStyleBackColor = true;
			this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
			// 
			// btnAddRoot
			// 
			this.btnAddRoot.Location = new System.Drawing.Point(36, 189);
			this.btnAddRoot.Name = "btnAddRoot";
			this.btnAddRoot.Size = new System.Drawing.Size(75, 23);
			this.btnAddRoot.TabIndex = 5;
			this.btnAddRoot.Text = "루트추가";
			this.btnAddRoot.UseVisualStyleBackColor = true;
			this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 644);
			this.Controls.Add(this.grpTreeList);
			this.Controls.Add(this.btnMsgBox);
			this.Controls.Add(this.btnModaless);
			this.Controls.Add(this.btnModal);
			this.Controls.Add(this.grpBar);
			this.Controls.Add(this.grpFont);
			this.Name = "MainForm";
			this.Text = "Control Test";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.grpFont.ResumeLayout(false);
			this.grpFont.PerformLayout();
			this.grpBar.ResumeLayout(false);
			this.grpBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
			this.grpTreeList.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label IbIFont;
		private System.Windows.Forms.GroupBox grpFont;
		private System.Windows.Forms.CheckBox chkItalic;
		private System.Windows.Forms.CheckBox chkBold;
		private System.Windows.Forms.TextBox txtSampleText;
		private System.Windows.Forms.ComboBox cboFont;
		private System.Windows.Forms.GroupBox grpBar;
		private System.Windows.Forms.ProgressBar pgDummy;
		private System.Windows.Forms.TrackBar tbDummy;
		private System.Windows.Forms.Button btnModal;
		private System.Windows.Forms.Button btnModaless;
		private System.Windows.Forms.Button btnMsgBox;
		private System.Windows.Forms.GroupBox grpTreeList;
		private System.Windows.Forms.ListView lvDummy;
		private System.Windows.Forms.TreeView tvDummy;
		private System.Windows.Forms.Button btnAddChild;
		private System.Windows.Forms.Button btnAddRoot;
	}
}

