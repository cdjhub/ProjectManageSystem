using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简易项目管理器
{
	public partial class ProjectForm : Form
	{
		public ShowTag st;
		Project project;
		ToolTip toolTip;
		string choose_version;
		MainForm mf;

		public ProjectForm()
		{
			InitializeComponent();
		}

		public ProjectForm(Project project)
		{
			InitializeComponent();

			this.Text = project.Pname;
			this.project = project;
		}

		public ProjectForm(Project project, MainForm mf)
		{
			InitializeComponent();

			this.Text = project.Pname;
			this.project = project;
			this.mf = mf;
		}

		private void ProjectForm_Load(object sender, EventArgs e)
		{
			initForm();
			initControls();
		}

		private void initForm()
		{
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Font = new Font("宋体", 12);
		}

		private void initControls()
		{
			initVersionTree();
			initLblIntroduction();
			initToolTip();
			initLblCreator();
			initLblCreateTime();
			initLblPath();
			initTagPanel();
			initBtnAddTag();
			initBtnNotSave();
			initBtnSave();
			initBtnSaveNewVersion();
			initBtnRestoreVersion();
			initBtnOpenFolder();
		}

		private void initBtnOpenFolder()
		{
			btnOpenFolder.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					Control ctl = sender as Control;
					ProjectForm pf = ctl.Parent as ProjectForm;
					pf.openProjectFolder();
				}
			);
		}

		private void initLblPath()
		{
			lblPath.Text = project.Path;
		}

		private void initBtnRestoreVersion()
		{
			btnRestoreVersion.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					Control ctl = sender as Control;
					ProjectForm pf = ctl.Parent as ProjectForm;
					pf.restoreVersion();
				}
				);
		}

		private void initBtnSave()
		{
			btnSave.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					Button btn = sender as Button;
					ProjectForm pf = btn.Parent as ProjectForm;
					pf.saveChange();
				});
		}

		private void initBtnSaveNewVersion()
		{
			int projectpid = project.Pid;
			string projectcreator = project.Creator;
			btnSaveNewVersion.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					Button btn = sender as Button;
					ProjectForm pf = btn.Parent as ProjectForm;
					NewVersionForm nvf = new NewVersionForm(project);
					nvf.ShowDialog();
					pf.initVersionTree();
				});
		}

		private void initBtnNotSave()
		{
			// 关闭窗口
			btnNotSave.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					Button btn = sender as Button;
					Form f = btn.Parent as Form;
					f.Close();
				}
			);
		}

		private void initBtnAddTag()
		{
			btnAddTag.Click += new EventHandler(ShowTools.btnAddTag_Click);
		}

		private void initTagPanel()
		{
			st = new ShowTag(TagPanel, project.Labels);
		}

		private void initLblCreateTime()
		{
			lblCreatTime.Text = project.Create_Time;
		}

		private void initLblCreator()
		{
			lblCreator.Text = project.Creator;
		}

		private void initToolTip()
		{
			toolTip = new ToolTip();
			toolTip.AutoPopDelay = 3000;
			toolTip.InitialDelay = 700;
			toolTip.ReshowDelay = 500;

			toolTip.SetToolTip(lblIntroduction, project.Introduction);
			toolTip.SetToolTip(btnAddTag, "标签间以空格隔开");
			toolTip.SetToolTip(btnSaveNewVersion, "在独立窗口中新建版本");
			toolTip.SetToolTip(btnSave, "只能保存标签的更改信息");
		}

		private void initLblIntroduction()
		{
			lblIntroduction.Text = project.Introduction;
			lblIntroduction.AutoEllipsis = true; // 显示省略号
		}

		public void initVersionTree()
		{
			treeView1.Nodes.Clear();
			ShowTools.buildVersionTree(project.Pid, treeView1);
			treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(
				delegate (object sender, TreeNodeMouseClickEventArgs e)
				{
					Control ctl = sender as Control;
					ProjectForm pf = ctl.Parent as ProjectForm;
					pf.setChooseVersion(e.Node);
				});
			treeView1.Scrollable = true;
		}

		public void saveChange()
		{
			List<string> lbls = new List<string>();
			foreach (MyCtlLib.MyTag tag in this.TagPanel.Controls)
				lbls.Add(tag.Lbl.Text);
			string lblsStr = Project.getLabelStr(lbls);

			// 更新到数据库
			LocalDatabase ld = LocalDatabase.getInstance();
			string sql = "update project set labels=" +
				Project.formatString(lblsStr) +
				" where pid=" +
				Project.int2str(project.Pid) +
			";";
			ld.change(sql);

			mf.flashProjectList();
			this.Close();
		}

		public void restoreVersion()
		{
			if (string.IsNullOrEmpty(choose_version))  // 如果没选版本就不用恢复
				return;
			MyIO.DeleteAll(project.Path, @".save_version");
			MyIO.CopyFolder(
				project.Path + @"/.save_version/" + choose_version + @"/",
				project.Path,
				@".save_version"
				);
		}

		public void setChooseVersion(TreeNode tn)
		{
			lblChooseVersion.Text = "已选版本：" + tn.Text;
			choose_version = tn.Name;
		}

		public void openProjectFolder()
		{
			System.Diagnostics.Process.Start("Explorer.exe", MyTools.path_save2use(project.Path));
		}

		private void btnMoveProject_Click(object sender, EventArgs e)
		{
			string newPath = "";
			System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
			fbd.Description = "请选择文件夹";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (string.IsNullOrEmpty(fbd.SelectedPath))
				{
					MessageBox.Show("文件夹路径不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
					return;
				}
				newPath = fbd.SelectedPath + "\\";
			}
			if (string.IsNullOrWhiteSpace(newPath))
				return;
			// 先复制整个项目文件夹过去
			MyIO.CopyFolder(MyTools.path_save2use(project.Path), newPath);
			// 更改数据库
			LocalDatabase ld = LocalDatabase.getInstance();
			string sql = "update project set path=" +
				Project.formatString(MyTools.path_use2save(newPath)) +
				" where pid=" + Project.int2str(project.Pid) +
			";";
			Console.WriteLine(sql);
			ld.change(sql);
			// 删除原有项目
			MyIO.DeleteAll(project.Path, "");
			// 刷新主窗口
			mf.flashProjectList();
			// 刷新数据
			project = mf.projects.findProject(project.Pid);
			// 修改数据显示
			lblPath.Text = MyTools.path_use2save(newPath);
			// 显示提示
			MessageBox.Show("迁移完成！");
		}
	}
}
