namespace 陈登佳文件与项目管理系统
{
	partial class NewProjectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TagPanel = new System.Windows.Forms.Panel();
			this.btnChangePath = new System.Windows.Forms.Button();
			this.btnAddTag = new System.Windows.Forms.Button();
			this.lblTags = new System.Windows.Forms.Label();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbIntroduction = new System.Windows.Forms.TextBox();
			this.lblIntroduction = new System.Windows.Forms.Label();
			this.lblProjectName = new System.Windows.Forms.Label();
			this.tbProjectName = new System.Windows.Forms.TextBox();
			this.tbCreator = new System.Windows.Forms.TextBox();
			this.lblCreator = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChangeClass = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TagPanel
			// 
			this.TagPanel.Location = new System.Drawing.Point(12, 383);
			this.TagPanel.Name = "TagPanel";
			this.TagPanel.Size = new System.Drawing.Size(452, 55);
			this.TagPanel.TabIndex = 0;
			// 
			// btnChangePath
			// 
			this.btnChangePath.Location = new System.Drawing.Point(401, 304);
			this.btnChangePath.Name = "btnChangePath";
			this.btnChangePath.Size = new System.Drawing.Size(107, 37);
			this.btnChangePath.TabIndex = 1;
			this.btnChangePath.Text = "更改路径";
			this.btnChangePath.UseVisualStyleBackColor = true;
			this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
			// 
			// btnAddTag
			// 
			this.btnAddTag.Location = new System.Drawing.Point(470, 383);
			this.btnAddTag.Name = "btnAddTag";
			this.btnAddTag.Size = new System.Drawing.Size(38, 55);
			this.btnAddTag.TabIndex = 1;
			this.btnAddTag.Text = "添加";
			this.btnAddTag.UseVisualStyleBackColor = true;
			// 
			// lblTags
			// 
			this.lblTags.AutoSize = true;
			this.lblTags.Location = new System.Drawing.Point(12, 356);
			this.lblTags.Name = "lblTags";
			this.lblTags.Size = new System.Drawing.Size(37, 15);
			this.lblTags.TabIndex = 2;
			this.lblTags.Text = "标签";
			// 
			// tbPath
			// 
			this.tbPath.Location = new System.Drawing.Point(15, 307);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(380, 25);
			this.tbPath.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(414, 444);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 44);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "确定";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbIntroduction
			// 
			this.tbIntroduction.Location = new System.Drawing.Point(270, 56);
			this.tbIntroduction.Multiline = true;
			this.tbIntroduction.Name = "tbIntroduction";
			this.tbIntroduction.Size = new System.Drawing.Size(238, 218);
			this.tbIntroduction.TabIndex = 5;
			// 
			// lblIntroduction
			// 
			this.lblIntroduction.AutoSize = true;
			this.lblIntroduction.Location = new System.Drawing.Point(267, 26);
			this.lblIntroduction.Name = "lblIntroduction";
			this.lblIntroduction.Size = new System.Drawing.Size(37, 15);
			this.lblIntroduction.TabIndex = 6;
			this.lblIntroduction.Text = "介绍";
			// 
			// lblProjectName
			// 
			this.lblProjectName.AutoSize = true;
			this.lblProjectName.Location = new System.Drawing.Point(15, 25);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(52, 15);
			this.lblProjectName.TabIndex = 7;
			this.lblProjectName.Text = "项目名";
			// 
			// tbProjectName
			// 
			this.tbProjectName.Location = new System.Drawing.Point(15, 56);
			this.tbProjectName.Name = "tbProjectName";
			this.tbProjectName.Size = new System.Drawing.Size(223, 25);
			this.tbProjectName.TabIndex = 8;
			// 
			// tbCreator
			// 
			this.tbCreator.Location = new System.Drawing.Point(15, 249);
			this.tbCreator.Name = "tbCreator";
			this.tbCreator.Size = new System.Drawing.Size(223, 25);
			this.tbCreator.TabIndex = 9;
			// 
			// lblCreator
			// 
			this.lblCreator.AutoSize = true;
			this.lblCreator.Location = new System.Drawing.Point(18, 210);
			this.lblCreator.Name = "lblCreator";
			this.lblCreator.Size = new System.Drawing.Size(52, 15);
			this.lblCreator.TabIndex = 10;
			this.lblCreator.Text = "创建者";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "当前分类";
			// 
			// btnChangeClass
			// 
			this.btnChangeClass.Location = new System.Drawing.Point(21, 139);
			this.btnChangeClass.Name = "btnChangeClass";
			this.btnChangeClass.Size = new System.Drawing.Size(217, 40);
			this.btnChangeClass.TabIndex = 11;
			this.btnChangeClass.Text = "无";
			this.btnChangeClass.UseVisualStyleBackColor = true;
			this.btnChangeClass.Click += new System.EventHandler(this.btnChangeClass_Click);
			// 
			// NewProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 500);
			this.Controls.Add(this.btnChangeClass);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblCreator);
			this.Controls.Add(this.tbCreator);
			this.Controls.Add(this.tbProjectName);
			this.Controls.Add(this.lblProjectName);
			this.Controls.Add(this.lblIntroduction);
			this.Controls.Add(this.tbIntroduction);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.lblTags);
			this.Controls.Add(this.btnAddTag);
			this.Controls.Add(this.btnChangePath);
			this.Controls.Add(this.TagPanel);
			this.Name = "NewProjectForm";
			this.Text = "新建项目";
			this.Load += new System.EventHandler(this.NewProjectForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel TagPanel;
		private System.Windows.Forms.Button btnChangePath;
		private System.Windows.Forms.Button btnAddTag;
		private System.Windows.Forms.Label lblTags;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbIntroduction;
		private System.Windows.Forms.Label lblIntroduction;
		private System.Windows.Forms.Label lblProjectName;
		private System.Windows.Forms.TextBox tbProjectName;
		private System.Windows.Forms.TextBox tbCreator;
		private System.Windows.Forms.Label lblCreator;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnChangeClass;
	}
}