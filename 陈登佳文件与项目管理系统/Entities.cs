using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 陈登佳文件与项目管理系统
{
	public abstract class Entities<T>
	{
		public static LocalDatabase ld = LocalDatabase.getInstance();
		public List<T> entities;
	}

	public class Projects : Entities<Project>
	{
		public Projects()
		{
			entities = select();
		}

		public Projects(int cid)
		{
			entities = select(cid);
		}

		public Projects(string sql)
		{
			entities = select(sql);
		}

		public Projects(List<Project> projects)
		{
			entities = projects;
		}

		public static List<Project> select(int cid=-2)
		{
			try
			{
				if (!File.Exists(LocalDatabase.dbName))
					MessageBox.Show("没有创建数据文件!");
				List<Project> res = new List<Project>();
				DataTable dt;
				if (cid == -2)
					dt = ld.select("select * from project;");
				else
					dt = ld.select("select * from project where cid=" +
						Entity.int2str(cid) + 
						";");

				foreach (DataRow dr in dt.Rows)
				{
					Project project = new Project();
					project.read(dr);
					res.Add(project);
				}
				return res;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return null;
		}

		public static List<Project> select(string sql)
		{
			try
			{
				List<Project> res = new List<Project>();
				DataTable dt = ld.select(sql);

				foreach (DataRow dr in dt.Rows)
				{
					Project project = new Project();
					project.read(dr);
					res.Add(project);
				}
				return res;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return null;
		}

		// 将数据添加进ListView中并显示
		public void displayInListView(ListView lv)
		{
			if (entities == null)
				return;
			foreach (Project p in entities)
			{
				ListViewItem item = new ListViewItem();
				item.Name = p.Pid.ToString();
				item.SubItems.Add(p.Pname);
				item.SubItems.Add(p.Creator);
				item.SubItems.Add(p.Create_Time);
				lv.Items.Add(item);
				item.EnsureVisible();
			}
		}

		// 搜索所有的projcet并返回
		public Project findProject(int pid)
		{
			return entities.Find(x => x.Pid == pid);
		}
	}

	public class Versions : Entities<Version>
	{
		public Versions()
		{
			entities = new List<Version>();
		}

		public Versions(string fa_vid)
		{
			entities = findSons(fa_vid:fa_vid);
		}

		public Versions(int pid)
		{
			entities = findSons(pid:pid);
		}

		public static List<Version> findSons(string fa_vid=null, int pid=-1)
		{
			if (string.IsNullOrEmpty(fa_vid) && pid == -1)
				return null;

			try
			{
				List<Version> listv = new List<Version>();

				string sql = "";
				if (string.IsNullOrEmpty(fa_vid))
					sql = "select * from version where fa_vid is null and pid=" +
						Entity.int2str(pid) + 
						";";
				else
					sql = "select * from version where fa_vid=" +
						Entity.formatString(fa_vid) +
						";";

				DataTable dt = ld.select(sql);
				foreach (DataRow dr in dt.Rows)
				{
					Version version = new Version();
					version.read(dr);
					listv.Add(version);
				}
				return listv;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return null;
		}
	}

	public class Classes : Entities<Class>
	{
		public Classes()
		{
			entities = new List<Class>();
		}

		public Classes(int fa_cid)
		{
			entities = findSons(fa_cid);
		}

		public static List<Class> findSons(int fa_cid)
		{
			try
			{
				List<Class> listv = new List<Class>();

				string sql = "";
				
				if(fa_cid != -1)
					sql = "select * from class where fa_cid=" +
						Entity.int2str(fa_cid) +
						";";
				else
					sql = "select * from class where fa_cid is " +
					Entity.int2str(fa_cid) +
					";";

				DataTable dt = ld.select(sql);
				foreach (DataRow dr in dt.Rows)
				{
					Class aclass = new Class();
					aclass.read(dr);
					listv.Add(aclass);
				}
				return listv;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return null;
		}
	}
}