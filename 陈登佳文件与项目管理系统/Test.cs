using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 陈登佳文件与项目管理系统
{
	/*
	 * 测试类
	 * 功能：执行测试函数
	 * 说明：写完就测
	 * 编写人：陈登佳
	 */
	class Test
	{
		static LocalDatabase a = LocalDatabase.getInstance();

		public static void sample()
		{
			System.Data.DataTable dt = a.select("Select * From sqlite_master where type='table'");

			Console.WriteLine("rows: " + dt.Rows.Count);
			foreach (System.Data.DataRow dataRow in dt.Rows)
			{
				for (int i = 0; i < dataRow.ItemArray.Length; i++)
					Console.Write(dataRow[i].ToString() + " ");
				Console.WriteLine("");
			}
		}

		public static void sample2()
		{
			//a.change("delete from class;");
			System.Data.DataTable dt = a.select("Select * From class;");

			Console.WriteLine("rows: " + dt.Rows.Count);
			foreach (System.Data.DataRow dataRow in dt.Rows)
			{
				for (int i = 0; i < dataRow.ItemArray.Length; i++)
					Console.Write(dataRow[i].ToString() + " ");
				Console.WriteLine("");
			}
		}

		public static void sample3()
		{
			//a.change("insert into version(vid, vname, submitter, pid) values('Udfz7B', '1.0', 'cdj', 123)");
			System.Data.DataTable dt = a.select("Select * From version;");

			Console.WriteLine("rows: " + dt.Rows.Count);
			foreach (System.Data.DataRow dataRow in dt.Rows)
			{
				for (int i = 0; i < dataRow.ItemArray.Length; i++)
					Console.Write(dataRow[i].ToString() + " ");
			}
		}

		public static void sample4()
		{
			System.Data.DataTable dt = a.select("Select * From project;");

			Console.WriteLine("rows: " + dt.Rows.Count);
			foreach (System.Data.DataRow dataRow in dt.Rows)
			{
				for (int i = 0; i < dataRow.ItemArray.Length; i++)
					Console.Write(dataRow[i].ToString() + " ");
				Console.WriteLine();
			}
		}


		public static void sample5(System.Windows.Forms.ListView lv)
		{
			lv.BeginUpdate();
			for (int i = 0; i < 10; i++)
			{
				System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem();
				item.Name = i.ToString();
				item.SubItems.Add("name"+i);
				item.SubItems.Add("creator"+i);
				item.SubItems.Add("time"+i);
				item.EnsureVisible();
				
				lv.Items.Add(item);
			}
			lv.EndUpdate();
		}

		public static void sample6()
		{
			//ld.change("insert into class(cid, cname, fa_cid) values(1, 'c1', null)");
			//ld.change("insert into class(cid, cname, fa_cid) values(2, 'c2', 1)");
			//ld.change("insert into class(cid, cname, fa_cid) values(6, 'c6', 5)");

			List<Class> c = Classes.findSons(5);
			foreach (Class ccc in c)
				Console.WriteLine(ccc.Cname);
		}

		public static void sample7()
		{
			//a.change("insert into version(vid, pid, submitter) values('100', 1, 'cdj');");
			//a.change("insert into version(vid, pid, submitter, fa_vid) values('101', 1, 'cdj', '100');");
			//a.change("insert into version(vid, pid, submitter, fa_vid) values('102', 1, 'cdj', '100');");
			List<Version> vs = Versions.findSons(fa_vid:"100");
			foreach (Version v in vs)
				Console.WriteLine(v.Vid);
		}

		public static void sample8()
		{
			//a.change("delete from version;");
			//a.change("insert into version(vid, pid, submitter) values('abc', 1, 'cdj');");
			//a.change("insert into version(vid, pid, submitter, fa_vid) values('abd', 1, 'cdj', 'abc');");
			//a.change("insert into version(vid, pid, submitter, fa_vid) values('abk', 1, 'cdj', 'abc');");
			List<Version> vs = Versions.findSons(fa_vid: "abc");
			foreach (Version v in vs)
				Console.WriteLine(v.Vid);
		}

		public static void sample9()
		{
			MyIO.CopyFolder(@"D:/test/a/", @"D:/test/b/", ".123");
		}

		public static void sample10()
		{
			MyIO.DeleteAll("D:/test/c/", ".123");
		}

		public static void sample11()
		{
			a.change("update project set cid=1 where pid>1;");
			sample4();
		}

		public static void sample12()
		{
			Project p = new Project(
				"123",
				"D:/test/",
				"acd",
				_introduction: "",
				_labels: "",
				_cid: -1
				);
			p.insert();
			
			sample4();
		}
	}
}
