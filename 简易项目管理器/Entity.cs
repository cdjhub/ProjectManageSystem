using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简易项目管理器
{
	/*
	 * 数据库实体类
	 * 功能：定义实体类基本功能
	 * 说明：
	 *		利用继承实现复用
	 *		利用get实现公有属性读取私有属性
	 * 编写人：陈登佳
	 */
	 /// <summary>
	 /// 数据库实体类
	 /// </summary>
	public abstract class Entity
	{
		public static LocalDatabase ld = LocalDatabase.getInstance();

		//从DataRow中读取数据
		public abstract void read(DataRow dr);
		//向表中插入数据
		public abstract void insert();
		//删除表中的数据
		public abstract void delete();

		// int转换为sql语句样式
		public static string int2str(int a)
		{
			if (a == -1)
				return "null";
			return a.ToString();
		}

		// 字串标准化为sql语句样式
		public static string formatString(string str)
		{
			if(string.IsNullOrEmpty(str))
				return "null";
			return "'" + str + "'";
		}

		// 从datarow中获取int数据
		public static int str2int(string col_name, DataRow dr)
		{
			string t = dr[col_name].ToString();
			if (string.IsNullOrEmpty(t))
				return -1;
			return int.Parse(t);
		}
	}

	/// <summary>
	/// 项目类型
	/// </summary>
	public class Class : Entity
	{
		int cid;		// not null
		int fa_cid;
		string cname;   // not null

		public int Cid			{ get { return cid; } }
		public int Fa_Cid		{ get { return fa_cid; } }
		public string Cname		{ get { return cname; } }

		public Class()
		{
			cid		= -1;
			fa_cid	= -1;
		}

		public Class(string _cname, int _fa_cid=-1)
		{
			fa_cid	= _fa_cid;
			cname	= _cname;
		}

		public override void read(DataRow dr)
		{
			try
			{
				cid = int.Parse(dr["cid"].ToString());
				fa_cid = str2int("fa_cid", dr);
				cname = dr["cname"].ToString();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public override void insert()
		{
			try
			{
				ld.change(@"insert into class(fa_cid, cname) values("+
					int2str(fa_cid)+",'"+
					cname+
					"');");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public override void delete()
		{
			try
			{
				delete(this.cid);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public void delete(int _cid)
		{
			try
			{
				if (_cid == -1)
					_cid = cid;
				if (_cid == -1)
					return;
				ld.change(@"delete from class where cid=" + _cid + ";");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}

	/// <summary>
	/// 项目版本
	/// </summary>
	public class Version : Entity
	{
		string vid;			// not null
		string fa_vid;
		string vname;
		string introduction;
		string submitter;		// not null
		string create_time;     // default
		int pid;                // not null

		public string Vid			{ get { return vid; } }
		public string Fa_Vid		{ get { return fa_vid; } }
		public string Vname			{ get { return vname; } }
		public string Introduction	{ get { return introduction; } }
		public string Submitter		{ get { return submitter; } }
		public string Create_Time	{ get { return create_time; } }
		public int Pid				{ get { return pid; } }

		public Version()
		{
			pid = -1;
		}

		public Version(string vid, string submitter, int pid, string fa_vid="", string vname="", string introduction="")
		{
			this.vid			= vid;
			this.submitter		= submitter;
			this.pid			= pid;
			this.fa_vid			= fa_vid;
			this.vname			= vname;
			this.introduction	= introduction;
		}

		public override void read(DataRow dr)
		{
			try
			{
				vid				= dr["vid"].ToString();
				fa_vid			= dr["fa_vid"].ToString();
				vname			= dr["vname"].ToString();
				introduction	= dr["introduction"].ToString();
				submitter		= dr["submitter"].ToString();
				create_time		= dr["create_time"].ToString();
				pid				= str2int("pid", dr);

				if (string.IsNullOrEmpty(vname))
					vname = vid;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public override void insert()
		{
			try
			{
				// 检查不能为空
				if (string.IsNullOrEmpty(vid) || string.IsNullOrEmpty(submitter) || pid == -1)
					return;
				
				string sql = @"insert into version(vid, fa_vid, vname, introduction, submitter, pid) values(" +
					formatString(vid)			+ "," +
					formatString(fa_vid)		+ "," +
					formatString(vname)			+ "," +
					formatString(introduction)	+ "," +
					formatString(submitter)		+ "," +
					pid + 
					");";

				ld.change(sql);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public override void delete()
		{
			try
			{
				delete(vid);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public void delete(string _vid)
		{
			try
			{
				if (string.IsNullOrEmpty(_vid))
					return;
				ld.change("delete from version where vid=" +
					formatString(_vid) +
					";");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}

	public class Project : Entity
	{
		int pid;				// autoincreament
		string pname;           // not null
		string introduction;
		string path;			// not null
		string creator;			// not null
		string create_time;		// default
		List<string> labels;
		string head_vid;
		string now_vid;
		int cid;

		public int Pid				{ get { return pid; } }
		public string Pname			{ get { return pname; } }
		public string Introduction	{ get { return introduction; } }
		public string Path			{ get { return path; } }
		public string Creator		{ get { return creator; } }
		public string Create_Time	{ get { return create_time; } }
		public List<string> Labels	{ get { return labels; } }
		public string Head_Vid		{ get { return head_vid; } }
		public string Now_Vid		{ get { return now_vid; } }
		public int Cid				{ get { return cid; } }

		public Project()
		{
			pid = -1;
			cid = -1;
		}

		public Project(string _pname, string _path, string _creator, int _pid=-1, string _introduction="", string _labels="", string _head_vid="", string _now_vid="", int _cid=-1)
		{
			pid				= _pid;
			pname			= _pname;
			introduction	= _introduction;
			path			= _path;
			creator			= _creator;
			labels			= getLabels(_labels);
			head_vid		= _head_vid;
			now_vid			= _now_vid;
			cid				= _cid;
		}

		public override void read(DataRow dr)
		{
			try
			{
				pid				= str2int("pid", dr);
				pname			= dr["pname"].ToString();
				introduction	= dr["introduction"].ToString();
				path			= dr["path"].ToString();
				creator			= dr["creator"].ToString();
				create_time		= dr["create_time"].ToString();
				labels			= getLabels(dr["labels"].ToString());
				head_vid		= dr["head_vid"].ToString();
				now_vid			= dr["now_vid"].ToString();
				cid				= str2int("cid", dr);

				if (string.IsNullOrEmpty(pname))
					pname = "项目" + pid;
				if (string.IsNullOrEmpty(introduction))
					introduction = "无介绍";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public override void insert()
		{
			try
			{
				if (string.IsNullOrEmpty(pname) ||
					string.IsNullOrEmpty(creator) ||
					string.IsNullOrEmpty(path))
					return;

				string sql = "insert into project(pname, introduction, path, creator, labels, head_vid, now_vid, cid) values(" +
					formatString(pname)					+ "," +
					formatString(introduction)			+ "," +
					formatString(path)					+ "," +
					formatString(creator)				+ "," +
					formatString(getLabelStr(labels))	+ "," +
					formatString(head_vid)				+ "," +
					formatString(now_vid)				+ "," +
					int2str(cid) + 
					");";
				ld.change(sql);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public override void delete()
		{
			try
			{
				delete(pid);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public void delete(int _pid)
		{
			try
			{
				if (_pid == -1)
					return;
				string sql = "delete from project where pid=" +
					int2str(_pid) + 
					";";
				ld.change(sql);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		public static List<string> getLabels(string str)
		{
			List<string> lbls = new List<string>();

			string t = "";
			foreach (char c in str)
			{
				if (c == ' ' && t.Length > 0)
				{
					lbls.Add(t);
					t = "";
				}
				if (c != ' ')
					t += c;
			}
			return lbls;
		}

		public static string getLabelStr(List<string> lbls)
		{
			string res = "";
			foreach (string str in lbls)
				res += str + " ";
			return res;
		}

		public static string getLabelStr(List<MyCtlLib.MyTag> myTags)
		{
			string res = "";
			foreach (MyCtlLib.MyTag myTag in myTags)
				res += myTag.Lbl.Text + " ";
			return res;
		}
	}
}
