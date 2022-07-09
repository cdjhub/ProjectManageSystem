using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陈登佳文件与项目管理系统
{
	public partial class NewProjectForm : Form
	{
		MainForm mf;
		public ShowTag st;
		int cid;

		public NewProjectForm()
		{
			InitializeComponent();
			cid = -1;
		}

		public NewProjectForm(MainForm mf)
		{
			InitializeComponent();
			this.mf = mf;
			cid = -1;
		}

		public NewProjectForm(MainForm mf, string creator)
		{
			InitializeComponent();
			this.tbCreator.Text = creator;
			this.mf = mf;
			cid = -1;
		}

		private void NewProjectForm_Load(object sender, EventArgs e)
		{
			initForm();
			initControls();
			initBtnAddTag();
		}

		private void initBtnAddTag()
		{
			btnAddTag.Click += new EventHandler(ShowTools.NPF_btnAddTag_Click);
		}

		private void initControls()
		{
			initTagPanel();
		}

		private void initTagPanel()
		{
			st = new ShowTag(TagPanel, Project.getLabels(""));
		}

		private void initForm()
		{
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Font = new Font("宋体", 12);
		}

		private bool checkNotNull()
		{
			// 检查是否满足非空约束
			if (string.IsNullOrWhiteSpace(tbProjectName.Text))
			{
				MessageBox.Show("项目名称是必须的，请输入项目名称！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (string.IsNullOrWhiteSpace(tbCreator.Text))
			{
				MessageBox.Show("创建者是必须的，请输入创建者！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (string.IsNullOrWhiteSpace(tbPath.Text))
			{
				MessageBox.Show("项目路径是必须的，请输入项目路径！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!checkNotNull())
				return;

			string lblsStr = Project.getLabelStr(st.tags);

			Project p = new Project(
				tbProjectName.Text,
				tbPath.Text,
				tbCreator.Text,
				_introduction: tbIntroduction.Text,
				_labels: lblsStr,
				_cid: cid
				);
			p.insert();
			
			mf.flashProjectList();
			this.Close();
		}

		private void btnChangePath_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
			fbd.Description = "请选择文件夹";
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				if (string.IsNullOrEmpty(fbd.SelectedPath))
				{
					MessageBox.Show("文件夹路径不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
					return;
				}
				tbPath.Text = fbd.SelectedPath + "\\";
				tbPath.Text = MyTools.path_use2save(tbPath.Text);
			}
		}

		public void setNowClass(int cid, string cname)
		{
			btnChangeClass.Text = cname;
			this.cid = cid;
		}

		private void btnChangeClass_Click(object sender, EventArgs e)
		{
			ClassChooseForm ccf = new ClassChooseForm(this);
			ccf.ShowDialog();
		}
	}
}
