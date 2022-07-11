namespace 简易项目管理器
{
	partial class ProjectForm
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
			this.components = new System.ComponentModel.Container();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.lblIntroduction = new System.Windows.Forms.Label();
			this.lblCreator = new System.Windows.Forms.Label();
			this.lblCreatTime = new System.Windows.Forms.Label();
			this.TagPanel = new System.Windows.Forms.Panel();
			this.lblTag = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblVersionTree = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRestoreVersion = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnNotSave = new System.Windows.Forms.Button();
			this.btnAddTag = new System.Windows.Forms.Button();
			this.btnSaveNewVersion = new System.Windows.Forms.Button();
			this.lblChooseVersion = new System.Windows.Forms.Label();
			this.lblPath = new System.Windows.Forms.Label();
			this.btnOpenFolder = new System.Windows.Forms.Button();
			this.btnMoveProject = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(34, 309);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(454, 325);
			this.treeView1.TabIndex = 0;
			// 
			// lblIntroduction
			// 
			this.lblIntroduction.Location = new System.Drawing.Point(34, 30);
			this.lblIntroduction.Name = "lblIntroduction";
			this.lblIntroduction.Size = new System.Drawing.Size(231, 102);
			this.lblIntroduction.TabIndex = 1;
			this.lblIntroduction.Text = "introduction";
			// 
			// lblCreator
			// 
			this.lblCreator.AutoSize = true;
			this.lblCreator.Location = new System.Drawing.Point(304, 58);
			this.lblCreator.Name = "lblCreator";
			this.lblCreator.Size = new System.Drawing.Size(63, 15);
			this.lblCreator.TabIndex = 2;
			this.lblCreator.Text = "creator";
			// 
			// lblCreatTime
			// 
			this.lblCreatTime.AutoSize = true;
			this.lblCreatTime.Location = new System.Drawing.Point(304, 117);
			this.lblCreatTime.Name = "lblCreatTime";
			this.lblCreatTime.Size = new System.Drawing.Size(87, 15);
			this.lblCreatTime.TabIndex = 3;
			this.lblCreatTime.Text = "Creat_Time";
			// 
			// TagPanel
			// 
			this.TagPanel.Location = new System.Drawing.Point(34, 208);
			this.TagPanel.Name = "TagPanel";
			this.TagPanel.Size = new System.Drawing.Size(415, 54);
			this.TagPanel.TabIndex = 4;
			// 
			// lblTag
			// 
			this.lblTag.AutoSize = true;
			this.lblTag.Location = new System.Drawing.Point(37, 188);
			this.lblTag.Name = "lblTag";
			this.lblTag.Size = new System.Drawing.Size(37, 15);
			this.lblTag.TabIndex = 5;
			this.lblTag.Text = "标签";
			// 
			// lblVersionTree
			// 
			this.lblVersionTree.AutoSize = true;
			this.lblVersionTree.Location = new System.Drawing.Point(38, 284);
			this.lblVersionTree.Name = "lblVersionTree";
			this.lblVersionTree.Size = new System.Drawing.Size(52, 15);
			this.lblVersionTree.TabIndex = 6;
			this.lblVersionTree.Text = "版本树";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(304, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "创建者：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(304, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "创建时间：";
			// 
			// btnRestoreVersion
			// 
			this.btnRestoreVersion.Location = new System.Drawing.Point(310, 268);
			this.btnRestoreVersion.Name = "btnRestoreVersion";
			this.btnRestoreVersion.Size = new System.Drawing.Size(175, 35);
			this.btnRestoreVersion.TabIndex = 8;
			this.btnRestoreVersion.Text = "恢复到选定版本";
			this.btnRestoreVersion.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(307, 655);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 31);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnNotSave
			// 
			this.btnNotSave.Location = new System.Drawing.Point(404, 654);
			this.btnNotSave.Name = "btnNotSave";
			this.btnNotSave.Size = new System.Drawing.Size(75, 32);
			this.btnNotSave.TabIndex = 10;
			this.btnNotSave.Text = "取消";
			this.btnNotSave.UseVisualStyleBackColor = true;
			// 
			// btnAddTag
			// 
			this.btnAddTag.Location = new System.Drawing.Point(455, 208);
			this.btnAddTag.Name = "btnAddTag";
			this.btnAddTag.Size = new System.Drawing.Size(33, 54);
			this.btnAddTag.TabIndex = 9;
			this.btnAddTag.Text = "添加";
			this.btnAddTag.UseVisualStyleBackColor = true;
			// 
			// btnSaveNewVersion
			// 
			this.btnSaveNewVersion.Location = new System.Drawing.Point(129, 268);
			this.btnSaveNewVersion.Name = "btnSaveNewVersion";
			this.btnSaveNewVersion.Size = new System.Drawing.Size(175, 35);
			this.btnSaveNewVersion.TabIndex = 8;
			this.btnSaveNewVersion.Text = "当前保存为新版";
			this.btnSaveNewVersion.UseVisualStyleBackColor = true;
			// 
			// lblChooseVersion
			// 
			this.lblChooseVersion.AutoEllipsis = true;
			this.lblChooseVersion.Location = new System.Drawing.Point(31, 655);
			this.lblChooseVersion.Name = "lblChooseVersion";
			this.lblChooseVersion.Size = new System.Drawing.Size(234, 34);
			this.lblChooseVersion.TabIndex = 11;
			this.lblChooseVersion.Text = "已选版本：";
			// 
			// lblPath
			// 
			this.lblPath.AutoEllipsis = true;
			this.lblPath.Location = new System.Drawing.Point(34, 155);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(270, 23);
			this.lblPath.TabIndex = 12;
			this.lblPath.Text = "path";
			// 
			// btnOpenFolder
			// 
			this.btnOpenFolder.Location = new System.Drawing.Point(307, 143);
			this.btnOpenFolder.Name = "btnOpenFolder";
			this.btnOpenFolder.Size = new System.Drawing.Size(88, 38);
			this.btnOpenFolder.TabIndex = 13;
			this.btnOpenFolder.Text = "打开";
			this.btnOpenFolder.UseVisualStyleBackColor = true;
			// 
			// btnMoveProject
			// 
			this.btnMoveProject.Location = new System.Drawing.Point(404, 143);
			this.btnMoveProject.Name = "btnMoveProject";
			this.btnMoveProject.Size = new System.Drawing.Size(88, 38);
			this.btnMoveProject.TabIndex = 13;
			this.btnMoveProject.Text = "迁移";
			this.btnMoveProject.UseVisualStyleBackColor = true;
			this.btnMoveProject.Click += new System.EventHandler(this.btnMoveProject_Click);
			// 
			// ProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 700);
			this.Controls.Add(this.btnMoveProject);
			this.Controls.Add(this.btnOpenFolder);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.lblChooseVersion);
			this.Controls.Add(this.btnNotSave);
			this.Controls.Add(this.btnAddTag);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnSaveNewVersion);
			this.Controls.Add(this.btnRestoreVersion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblVersionTree);
			this.Controls.Add(this.lblTag);
			this.Controls.Add(this.TagPanel);
			this.Controls.Add(this.lblCreatTime);
			this.Controls.Add(this.lblCreator);
			this.Controls.Add(this.lblIntroduction);
			this.Controls.Add(this.treeView1);
			this.Name = "ProjectForm";
			this.Text = "ProjectForm";
			this.Load += new System.EventHandler(this.ProjectForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label lblIntroduction;
		private System.Windows.Forms.Label lblCreator;
		private System.Windows.Forms.Label lblCreatTime;
		private System.Windows.Forms.Panel TagPanel;
		private System.Windows.Forms.Label lblTag;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblVersionTree;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRestoreVersion;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnNotSave;
		private System.Windows.Forms.Button btnAddTag;
		private System.Windows.Forms.Button btnSaveNewVersion;
		private System.Windows.Forms.Label lblChooseVersion;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Button btnOpenFolder;
		private System.Windows.Forms.Button btnMoveProject;
	}
}