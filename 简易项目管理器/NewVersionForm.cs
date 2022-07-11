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
	public partial class NewVersionForm : Form
	{
		int pid;
		string fa_vid;
		string submitter;
		Project project;

		public NewVersionForm()
		{
			InitializeComponent();
		}

		public NewVersionForm(Project project)
		{
			InitializeComponent();
			this.project = project;
			this.pid = project.Pid;
			this.submitter = project.Creator;
		}

		public NewVersionForm(int pid)
		{
			InitializeComponent();
			this.pid = pid;
		}

		public NewVersionForm(int pid, string submitter)
		{
			InitializeComponent();
			this.pid = pid;
			this.submitter = submitter;
		}

		private void NewVersionForm_Load(object sender, EventArgs e)
		{
			fa_vid = "";

			initForm();
			initControls();
		}

		private void initControls()
		{
			initBtnNotSave();
			initBtnSave();
			initVersionTree();
			initBtnDeselectFa();
			initTbSubmitter();
			initToolTip();
		}

		private void initBtnSave()
		{
			btnSave.Click += new EventHandler(
				delegate (object sender, EventArgs e) 
				{
					Button btn = sender as Button;
					NewVersionForm nvf = btn.Parent as NewVersionForm;
					nvf.SaveVersion();
				}
				);
		}

		private void initToolTip()
		{
			ToolTip tt = new ToolTip();
			tt.AutoPopDelay = 3000;
			tt.InitialDelay = 700;
			tt.ReshowDelay = 500;

			tt.SetToolTip(lblFaVersion, "双击选择，可以不选");
		}

		private void initTbSubmitter()
		{
			tbSubmitter.Text = submitter;
		}

		private void initBtnDeselectFa()
		{
			btnDeselectFa.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					Button btn = sender as Button;
					NewVersionForm nvf = btn.Parent as NewVersionForm;
					nvf.DeselectFaVid();
				}
				);
		}

		private void initVersionTree()
		{
			ShowTools.buildVersionTree(pid, treeView1);
			treeView1.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(
				delegate (object sender, TreeNodeMouseClickEventArgs e)
				{
					TreeView ctrl = sender as TreeView;
					NewVersionForm nvf = ctrl.Parent as NewVersionForm;
					nvf.setFaVid(e.Node);
				}
				);
			treeView1.Scrollable = true;
		}

		private void initBtnNotSave()
		{
			btnNotSave.Click += new EventHandler(delegate (object sender, EventArgs e) 
				{
					Button btn = sender as Button;
					Form f = btn.Parent as Form;
					f.Close();
				});
		}

		private void initForm()
		{
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Font = new Font("宋体", 12);
		}

		public void setFaVid(TreeNode tn)
		{
			fa_vid = tn.Name;
			lblNowFaName.Text = "当前父版本：" + tn.Text;
		}

		public void DeselectFaVid()
		{
			fa_vid = "";
			lblNowFaName.Text = "当前父版本：";
		}

		public void SaveVersionFolder(string vid)
		{
			MyIO.CopyFolder(project.Path, 
				project.Path + @"/.save_version/" + vid + @"/", 
				@".save_version"
				);
		}

		public void SaveVersion()
		{
			if (string.IsNullOrWhiteSpace(tbSubmitter.Text))
			{
				MessageBox.Show( "请输入提交者！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			string vid = MyTools.getRandomString(8);
			SaveVersionFolder(vid);
			Version newVersion = new Version(
				vid,
				tbSubmitter.Text,
				pid,
				fa_vid: fa_vid,
				vname: tbVersionName.Text,
				introduction: tbIntroduction.Text
				);
			newVersion.insert();
			MessageBox.Show("当前版本保存成功!");
			this.Close();
		}
	}
}
