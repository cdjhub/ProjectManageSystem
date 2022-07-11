using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyCtlLib;

namespace 简易项目管理器
{
	class ShowTools
	{
		// 双击后新建一个项目窗口
		public static void lvProjectList_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListView lv = sender as ListView;
			ListViewHitTestInfo info = lv.HitTest(e.X, e.Y);  // 获得点击位置的info
			MainForm mf = lv.Parent as MainForm;
			Project project = mf.projects.findProject(int.Parse(info.Item.Name)); // 找到对应的“项目”对象
			//Console.WriteLine("Double Click : " + info.Item.Name);
			ProjectForm pf = new ProjectForm(project, mf);
			pf.Show();
		}

		// 项目窗口中建立版本树
		public static void buildVersionTree(int pid, TreeView tree)
		{
			Versions firstLayer = new Versions(pid);
			foreach (Version v in firstLayer.entities)
			{
				tree.Nodes.Add(v.Vid, v.Vname);
				TreeNode tn = tree.Nodes.Find(v.Vid, false)[0];
				buildVersionNode(tn, v.Vid);
			}
		}
		 // 深度优先遍历
		static void buildVersionNode(TreeNode tn, string fa_vid)
		{
			Versions nowLayer = new Versions(fa_vid);
			if (nowLayer == null)
				return;
			foreach (Version v in nowLayer.entities)
			{
				tn.Nodes.Add(v.Vid, v.Vname);
				TreeNode newTN = tn.Nodes.Find(v.Vid, false)[0];
				buildVersionNode(newTN, v.Vid);
			}
		}

		// 单击添加标签
		public static void btnAddTag_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			ProjectForm pf = btn.Parent as ProjectForm;
			string res = Microsoft.VisualBasic.Interaction.InputBox("多个标签请用空格隔开", "添加标签");
			res += " ";  // 方便转成list
			List<string> tagsStr = Project.getLabels(res);

			foreach (string tagStr in tagsStr)
				pf.st.tags.Add(new MyTag(tagStr));
			pf.st.TagPanel.Controls.Clear();
			pf.st.setStyle();
		}

		// 单击添加标签, 在新建项目窗口中
		public static void NPF_btnAddTag_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			NewProjectForm npf = btn.Parent as NewProjectForm;
			string res = Microsoft.VisualBasic.Interaction.InputBox("多个标签请用空格隔开", "添加标签");
			res += " ";  // 方便转成list
			List<string> tagsStr = Project.getLabels(res);

			foreach (string tagStr in tagsStr)
				npf.st.tags.Add(new MyTag(tagStr));
			npf.st.TagPanel.Controls.Clear();
			npf.st.setStyle();
		}

		// 点击删除标签
		public static void btnDelTag_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			Panel panel = btn.Parent.Parent as Panel;
			panel.Controls.Remove(btn.Parent);
		}

		// 项目窗口中建立分类树
		public static void buildClassTree(TreeView tree)
		{
			Classes firstLayer = new Classes(-1);
			foreach (Class c in firstLayer.entities)
			{
				tree.Nodes.Add(c.Cid.ToString(), c.Cname);
				TreeNode tn = tree.Nodes.Find(c.Cid.ToString(), false)[0];
				buildClassNode(tn, c.Cid);
			}
		}
		// 深度优先遍历
		static void buildClassNode(TreeNode tn, int fa_cid)
		{
			Classes nowLayer = new Classes(fa_cid);
			if (nowLayer == null)
				return;
			foreach (Class c in nowLayer.entities)
			{
				tn.Nodes.Add(c.Cid.ToString(), c.Cname);
				TreeNode newTN = tn.Nodes.Find(c.Cid.ToString(), false)[0];
				buildClassNode(newTN, c.Cid);
			}
		}
	}

	interface HaveShowTag
	{
		ShowTag GetShowTag();
	}

	/*
	 * 显示多个标签
	 * 功能：panel中显示多个Tag
	 * 编写人：陈登佳
	 */
	public class ShowTag
	{
		Panel panel;
		public List<MyTag> tags;
		static int margin = 5;

		public Panel TagPanel
		{
			get { return panel; }
		}

		public ShowTag()
		{
			panel = new Panel();
			tags = new List<MyTag>();
			setPanel();
		}

		public ShowTag(Panel _panel, List<string> labels)
		{
			panel = _panel;
			setPanel();
			tags = new List<MyTag>();
			createTags(labels);
			setStyle();
		}

		public ShowTag(Form father, System.Drawing.Point point, List<string> labels)
		{
			panel = new Panel();
			setPanel(father, point);
			tags = new List<MyTag>();
			createTags(labels);
			setStyle();

			father.Controls.Add(this.panel);
		}
		
		// 创建并添加labels控件
		public void createTags(List<string> labels)
		{
			if (labels == null)
				return;
			foreach (string str in labels)
			{
				MyTag tag = new MyTag(str);
				tags.Add(tag);
			}
		}

		// 设置Tag显示格式
		public void setStyle()
		{
			int x = 0, y = margin;
			
			foreach (MyTag tag in tags)
			{
				tag.AutoScaleMode = AutoScaleMode.None;
				tag.Btn.Click += new EventHandler(ShowTools.btnDelTag_Click);
				while (tag.Width > panel.Width)   // 如果单个标签过长，直接循环对半砍
				{
					string showStr = tag.Lbl.Text;
					string str = showStr.Substring(0, showStr.Length / 2 + 1);
					tag.setText(str);
				}

				if (x + tag.Width > panel.Width) // 换行显示
				{
					x = margin;
					y += MyTag.height + margin;
				}
				else
				{
					x += margin;
				}
				tag.Location = new System.Drawing.Point(x, y);
				panel.Controls.Add(tag);
				x += tag.Width;
			}
		}

		private void setPanel()
		{
			panel.AutoSize = false;
			panel.AutoScroll = true;
			panel.BackColor = System.Drawing.Color.FromArgb(100, 150, 150, 150);
		}

		private void setPanel(Form father, System.Drawing.Point point)
		{
			panel.AutoSize = false;
			panel.AutoScroll = true;
			panel.BackColor = System.Drawing.Color.FromArgb(100, 150, 150, 150);
			panel.Size = new System.Drawing.Size(father.Width-20, 70);
			panel.Location = point;
			setPanel();
		}
	}
}