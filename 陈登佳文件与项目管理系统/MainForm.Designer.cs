namespace 陈登佳文件与项目管理系统
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNowUser = new System.Windows.Forms.Label();
			this.tbUserName = new System.Windows.Forms.TextBox();
			this.lvProjectList = new System.Windows.Forms.ListView();
			this.btnChooseClass = new System.Windows.Forms.Button();
			this.lblClass = new System.Windows.Forms.Label();
			this.btnNewProject = new System.Windows.Forms.Button();
			this.btnSaveUserName = new System.Windows.Forms.Button();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbSearchPName = new System.Windows.Forms.CheckBox();
			this.cbSearchPath = new System.Windows.Forms.CheckBox();
			this.cbSearchCreatTime = new System.Windows.Forms.CheckBox();
			this.cbSearchIntroduction = new System.Windows.Forms.CheckBox();
			this.cbSearchCreator = new System.Windows.Forms.CheckBox();
			this.cbSearchTag = new System.Windows.Forms.CheckBox();
			this.gbSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNowUser
			// 
			this.lblNowUser.AutoSize = true;
			this.lblNowUser.Location = new System.Drawing.Point(0, 0);
			this.lblNowUser.Name = "lblNowUser";
			this.lblNowUser.Size = new System.Drawing.Size(82, 15);
			this.lblNowUser.TabIndex = 0;
			this.lblNowUser.Text = "当前用户：";
			// 
			// tbUserName
			// 
			this.tbUserName.Location = new System.Drawing.Point(79, 0);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.Size = new System.Drawing.Size(100, 25);
			this.tbUserName.TabIndex = 1;
			// 
			// lvProjectList
			// 
			this.lvProjectList.HideSelection = false;
			this.lvProjectList.Location = new System.Drawing.Point(10, 243);
			this.lvProjectList.Name = "lvProjectList";
			this.lvProjectList.Size = new System.Drawing.Size(500, 400);
			this.lvProjectList.TabIndex = 2;
			this.lvProjectList.UseCompatibleStateImageBehavior = false;
			// 
			// btnChooseClass
			// 
			this.btnChooseClass.Location = new System.Drawing.Point(95, 200);
			this.btnChooseClass.Name = "btnChooseClass";
			this.btnChooseClass.Size = new System.Drawing.Size(75, 23);
			this.btnChooseClass.TabIndex = 3;
			this.btnChooseClass.Text = "所有分类";
			this.btnChooseClass.UseVisualStyleBackColor = true;
			// 
			// lblClass
			// 
			this.lblClass.AutoSize = true;
			this.lblClass.Location = new System.Drawing.Point(6, 210);
			this.lblClass.Name = "lblClass";
			this.lblClass.Size = new System.Drawing.Size(82, 15);
			this.lblClass.TabIndex = 4;
			this.lblClass.Text = "当前分类：";
			// 
			// btnNewProject
			// 
			this.btnNewProject.Location = new System.Drawing.Point(369, 200);
			this.btnNewProject.Name = "btnNewProject";
			this.btnNewProject.Size = new System.Drawing.Size(139, 37);
			this.btnNewProject.TabIndex = 5;
			this.btnNewProject.Text = "新建项目";
			this.btnNewProject.UseVisualStyleBackColor = true;
			// 
			// btnSaveUserName
			// 
			this.btnSaveUserName.Location = new System.Drawing.Point(361, 9);
			this.btnSaveUserName.Name = "btnSaveUserName";
			this.btnSaveUserName.Size = new System.Drawing.Size(147, 39);
			this.btnSaveUserName.TabIndex = 6;
			this.btnSaveUserName.Text = "保存用户名";
			this.btnSaveUserName.UseVisualStyleBackColor = true;
			this.btnSaveUserName.Click += new System.EventHandler(this.btnSaveUserName_Click);
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.cbSearchPath);
			this.gbSearch.Controls.Add(this.cbSearchTag);
			this.gbSearch.Controls.Add(this.cbSearchIntroduction);
			this.gbSearch.Controls.Add(this.cbSearchCreator);
			this.gbSearch.Controls.Add(this.cbSearchCreatTime);
			this.gbSearch.Controls.Add(this.cbSearchPName);
			this.gbSearch.Controls.Add(this.tbSearch);
			this.gbSearch.Controls.Add(this.btnSearch);
			this.gbSearch.Location = new System.Drawing.Point(12, 54);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Size = new System.Drawing.Size(496, 116);
			this.gbSearch.TabIndex = 8;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "搜索项目";
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(7, 30);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(382, 25);
			this.tbSearch.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(395, 27);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(93, 37);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "搜索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cbSearchPName
			// 
			this.cbSearchPName.AutoSize = true;
			this.cbSearchPName.Location = new System.Drawing.Point(7, 62);
			this.cbSearchPName.Name = "cbSearchPName";
			this.cbSearchPName.Size = new System.Drawing.Size(89, 19);
			this.cbSearchPName.TabIndex = 6;
			this.cbSearchPName.Text = "项目名称";
			this.cbSearchPName.UseVisualStyleBackColor = true;
			// 
			// cbSearchPath
			// 
			this.cbSearchPath.AutoSize = true;
			this.cbSearchPath.Location = new System.Drawing.Point(7, 87);
			this.cbSearchPath.Name = "cbSearchPath";
			this.cbSearchPath.Size = new System.Drawing.Size(89, 19);
			this.cbSearchPath.TabIndex = 6;
			this.cbSearchPath.Text = "项目路径";
			this.cbSearchPath.UseVisualStyleBackColor = true;
			// 
			// cbSearchCreatTime
			// 
			this.cbSearchCreatTime.AutoSize = true;
			this.cbSearchCreatTime.Location = new System.Drawing.Point(129, 64);
			this.cbSearchCreatTime.Name = "cbSearchCreatTime";
			this.cbSearchCreatTime.Size = new System.Drawing.Size(89, 19);
			this.cbSearchCreatTime.TabIndex = 6;
			this.cbSearchCreatTime.Text = "创建时间";
			this.cbSearchCreatTime.UseVisualStyleBackColor = true;
			// 
			// cbSearchIntroduction
			// 
			this.cbSearchIntroduction.AutoSize = true;
			this.cbSearchIntroduction.Location = new System.Drawing.Point(129, 89);
			this.cbSearchIntroduction.Name = "cbSearchIntroduction";
			this.cbSearchIntroduction.Size = new System.Drawing.Size(89, 19);
			this.cbSearchIntroduction.TabIndex = 6;
			this.cbSearchIntroduction.Text = "介绍信息";
			this.cbSearchIntroduction.UseVisualStyleBackColor = true;
			// 
			// cbSearchCreator
			// 
			this.cbSearchCreator.AutoSize = true;
			this.cbSearchCreator.Location = new System.Drawing.Point(248, 63);
			this.cbSearchCreator.Name = "cbSearchCreator";
			this.cbSearchCreator.Size = new System.Drawing.Size(74, 19);
			this.cbSearchCreator.TabIndex = 6;
			this.cbSearchCreator.Text = "创建者";
			this.cbSearchCreator.UseVisualStyleBackColor = true;
			// 
			// cbSearchTag
			// 
			this.cbSearchTag.AutoSize = true;
			this.cbSearchTag.Location = new System.Drawing.Point(248, 89);
			this.cbSearchTag.Name = "cbSearchTag";
			this.cbSearchTag.Size = new System.Drawing.Size(59, 19);
			this.cbSearchTag.TabIndex = 6;
			this.cbSearchTag.Text = "标签";
			this.cbSearchTag.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 660);
			this.Controls.Add(this.gbSearch);
			this.Controls.Add(this.btnSaveUserName);
			this.Controls.Add(this.btnNewProject);
			this.Controls.Add(this.lblClass);
			this.Controls.Add(this.btnChooseClass);
			this.Controls.Add(this.lvProjectList);
			this.Controls.Add(this.tbUserName);
			this.Controls.Add(this.lblNowUser);
			this.Name = "MainForm";
			this.Text = "陈登佳文件与项目管理系统";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNowUser;
		private System.Windows.Forms.TextBox tbUserName;
		private System.Windows.Forms.ListView lvProjectList;
		private System.Windows.Forms.Button btnChooseClass;
		private System.Windows.Forms.Label lblClass;
		private System.Windows.Forms.Button btnNewProject;
		private System.Windows.Forms.Button btnSaveUserName;
		private System.Windows.Forms.GroupBox gbSearch;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.CheckBox cbSearchPath;
		private System.Windows.Forms.CheckBox cbSearchTag;
		private System.Windows.Forms.CheckBox cbSearchIntroduction;
		private System.Windows.Forms.CheckBox cbSearchCreator;
		private System.Windows.Forms.CheckBox cbSearchCreatTime;
		private System.Windows.Forms.CheckBox cbSearchPName;
	}
}

