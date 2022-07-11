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
	public partial class ClassChooseForm : Form
	{
		public MainForm mf;
		public NewProjectForm npf;
		int choose_cid;
		string choose_cname;
		string Mode;

		public ClassChooseForm()
		{
			InitializeComponent();
			choose_cid = -1;
			choose_cname = "所有分类";
			Mode = "";
		}

		public ClassChooseForm(MainForm mf)
		{
			InitializeComponent();
			choose_cid = -1;
			choose_cname = "所有分类";
			this.mf = mf;
			Mode = "MainForm";
		}

		public ClassChooseForm(NewProjectForm npf)
		{
			InitializeComponent();
			choose_cid = -1;
			choose_cname = "所有分类";
			this.npf = npf;
			Mode = "NewProjectForm";
		}

		private void ClassChooseForm_Load(object sender, EventArgs e)
		{
			initForm();
			initControls();
		}

		private void initControls()
		{
			initBtnSave();
			initBtnNotSave();
			initBtnNewClass();
			initClassTree();
			initCheckBox();
			initLblNowClass();
		}

		private void initBtnNewClass()
		{
			btnNewClass.Click += new EventHandler(
				delegate (object sender, EventArgs e) 
				{
					Button btn = sender as Button;
					ClassChooseForm ccf = btn.Parent as ClassChooseForm;
					ccf.newClass();
				}
			);
		}

		private void initLblNowClass()
		{
			lblNowClass.AutoEllipsis = true;
			lblNowClass.AutoSize = false;
			lblNowClass.Size = new Size(400, 40);
		}

		private void initCheckBox()
		{
			checkBox1.Font = new Font("宋体", 8);
			checkBox1.Checked = true;
		}

		public void initClassTree()
		{
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add("-1", "所有分类");
			ShowTools.buildClassTree(treeView1);
			treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(
				delegate (object sender, TreeNodeMouseClickEventArgs e)
				{
					Control tv = sender as Control;
					ClassChooseForm ccf = tv.Parent as ClassChooseForm;
					ccf.setChooseClass(e.Node);
				}
			);
			treeView1.Scrollable = true;
		}

		private void initBtnNotSave()
		{
			btnNotSave.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					Button btn = sender as Button;
					ClassChooseForm ccf = btn.Parent as ClassChooseForm;
					ccf.Close();
				}
			);
		}

		private void initBtnSave()
		{
			if (Mode.Equals("MainForm"))
			{
				btnSave.Click += new EventHandler(
					delegate (object sender, EventArgs e)
					{
						Button btn = sender as Button;
						ClassChooseForm ccf = btn.Parent as ClassChooseForm;
						ccf.mf.setNowClass(choose_cid, choose_cname);
						ccf.Close();
					}
				);
			}
			else if (Mode.Equals("NewProjectForm"))
			{
				btnSave.Click += new EventHandler(
					delegate (object sender, EventArgs e)
					{
						Button btn = sender as Button;
						ClassChooseForm ccf = btn.Parent as ClassChooseForm;
						ccf.npf.setNowClass(choose_cid, choose_cname);
						ccf.Close();
					}
				);
			}
		}

		private void initForm()
		{
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Font = new Font("宋体", 12);
		}

		void setChooseClass(TreeNode tn)
		{
			choose_cid = (string.IsNullOrEmpty(tn.Name) ? -1 : int.Parse(tn.Name));
			choose_cname = tn.Text;
			lblNowClass.Text = "当前分类：" + tn.Text; 
		}

		private void newClass()
		{
			string str = Microsoft.VisualBasic.Interaction.InputBox("请输入分类名，不输入则取消新建", "新建分类");
			if (string.IsNullOrWhiteSpace(str))
				return;
			saveNewClass(str);
			initClassTree();
		}

		private void saveNewClass(string cname)
		{
			if (checkBox1.Checked)
			{
				Class c = new Class(cname, choose_cid);
				c.insert();
			}
			else
			{
				Class c = new Class(cname);
				c.insert();
			}
		}
	}
}
