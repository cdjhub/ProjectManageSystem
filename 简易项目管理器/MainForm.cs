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
	public partial class MainForm : Form
	{
		static int padding = 10;
		int accmulation_y = 0;
		public Projects projects;

		public MainForm()
		{
			InitializeComponent();
			LocalDatabase ld = LocalDatabase.getInstance();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//chart1.Series.Add("line1");
			//chart1.Series["line1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

			initForm();
			initControls();
			Test.sample4();
		}

		private void initControls()
		{
			initLblNowUser();
			initTbUserName();
			initBtnChooseClass();
			accmulation_y += tbUserName.Height;
			initlvProjectList();
			initBtnNewProject();
			initCbSearch();
		}

		private void initCbSearch()
		{
		}

		private void initBtnNewProject()
		{
			string username = tbUserName.Text;
			btnNewProject.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					NewProjectForm npf = new NewProjectForm(this, username);
					npf.Show();
				}
			);
		}

		private void initBtnChooseClass()
		{
			MainForm mf = this;
			Point p = btnChooseClass.Location;
			btnChooseClass.Size = new Size(100, 30);
			btnChooseClass.Location = new Point(lblClass.Location.X + lblClass.Width + 1, p.Y);
			btnChooseClass.Click += new EventHandler(
				delegate (object sender, EventArgs e)
				{
					ClassChooseForm ccf = new ClassChooseForm(mf);
					ccf.ShowDialog();
				}
			);
		}

		private void initlvProjectList()
		{
			lvProjectList.Font = new Font("宋体", 10);
			lvProjectList.View = View.Details;
			lvProjectList.HoverSelection = true;
			lvProjectList.FullRowSelect = true;     // 关键的一句，没这个设置无法选中，也无法触发双击
			lvProjectList.MultiSelect = false;
			lvProjectList.MouseDoubleClick += new MouseEventHandler(ShowTools.lvProjectList_MouseDoubleClick);

			lvProjectList.Columns.Add("uselessItem", "", 0);
			ColumnHeader ch1 = new ColumnHeader();
			ch1.Text = ch1.Name = "项目名";
			ch1.Width = 220;
			ch1.TextAlign = HorizontalAlignment.Left;
			lvProjectList.Columns.Add(ch1);

			ColumnHeader ch2 = new ColumnHeader();
			ch2.Text = ch2.Name = "创建者";
			ch2.Width = 80;
			ch2.TextAlign = HorizontalAlignment.Left;
			lvProjectList.Columns.Add(ch2);

			ColumnHeader ch3 = new ColumnHeader();
			ch3.Text = ch3.Name = "时间";
			ch3.Width = 150;
			ch3.TextAlign = HorizontalAlignment.Left;
			lvProjectList.Columns.Add(ch3);

			flashProjectList();
		}

		// 设置数据项并显示，并附带更新数据项改动的功能
		public void flashProjectList()
		{
			lvProjectList.Items.Clear();
			projects = new Projects(); // 更新数据改动
			projects.displayInListView(lvProjectList);
		}

		private void LvProjectList_DoubleClick(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void initLblNowUser()
		{
			lblNowUser.Location = new Point(padding, padding + 5);  // 往下移动一点，居中显示
		}

		private void initTbUserName()
		{
			tbUserName.Location = new Point(lblNowUser.Width+5, padding);

			string username = Properties.Settings.Default.UserName;
			if (!string.IsNullOrEmpty(username))
				tbUserName.Text = username;
			else
				tbUserName.Text = "游客" + MyTools.getRandomString(4);
		}

		private void initForm()
		{
			// 设置不能改变窗口大小
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			// 设置初始窗口位置
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			// 设置是否自动调整大小
			this.AutoSize = false;
			// 自动产生滚动条
			this.AutoScroll = false;
			// 设置缩放模式为不允许缩放，因为改变字体大小很有可能会让窗口无限变大
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

			this.Font = new Font("宋体", 12);
		}

		public void setNowClass(int cid, string cname)
		{
			btnChooseClass.Text = cname;
			lvProjectList.Items.Clear();
			if (cid == -1)
				projects = new Projects();    // 所有分类
			else
				projects = new Projects(cid); // 某个分类
			projects.displayInListView(lvProjectList);
		}

		private void btnSaveUserName_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.UserName = tbUserName.Text;
			Properties.Settings.Default.Save();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (!cbSearchCreator.Checked && !cbSearchCreatTime.Checked && !cbSearchIntroduction.Checked && !cbSearchPath.Checked && !cbSearchPName.Checked && !cbSearchTag.Checked)
			{
				flashProjectList();
				return;
			}
			if (string.IsNullOrWhiteSpace(tbSearch.Text))
				return;

			// 组合sql语句
			string str = "'%" + tbSearch.Text + "%'";
			bool has_first = false;
			string sql = "select * from project where;";
			sql = combineSql(sql, ref has_first, str, "creator", cbSearchCreator);
			sql = combineSql(sql, ref has_first, str, "create_time", cbSearchCreatTime);
			sql = combineSql(sql, ref has_first, str, "introduction", cbSearchIntroduction);
			sql = combineSql(sql, ref has_first, str, "path", cbSearchPath);
			sql = combineSql(sql, ref has_first, str, "pname", cbSearchPName);
			sql = combineSql(sql, ref has_first, str, "labels", cbSearchTag);

			lvProjectList.Items.Clear();
			projects = new Projects(sql); // 更新数据改动
			projects.displayInListView(lvProjectList);

			Console.WriteLine(sql);
		}

		string combineSql(string sql, ref bool has_first, string str, string cbStr, CheckBox cb)
		{
			if (cb.Checked)
			{
				if (has_first) sql = sql.Insert(sql.Length - 1, " or");
				sql = sql.Insert(sql.Length - 1, " " + cbStr + " like " + str);
				has_first = true;
			}
			return sql;
		}
	}
}
