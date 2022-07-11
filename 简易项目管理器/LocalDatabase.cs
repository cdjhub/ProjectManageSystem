using System;
using System.Data.SQLite;

namespace 简易项目管理器
{
	/*
	 * 本地数据库类
	 * 功能：作为底层负责与数据库文件进行交互 
	 * 说明：
	 *		sqlite可以直接使用本地数据库文件存储数据
	 *		使用单例模式，统一交互
	 *		没有数据库文件时，先创建数据库文件再创建表结构
	 * 编写人：陈登佳
	 */
	public class LocalDatabase
	{
		public static string dbName = "LocalDatabase.sqlite";
		private static LocalDatabase instance;

		SQLiteConnection con;
		SQLiteCommand cmd;

		private LocalDatabase()
		{
			try
			{
				if (!System.IO.File.Exists(dbName))
				{
					SQLiteConnection.CreateFile(dbName);
					string sql = @"CREATE TABLE class(
						cid INTEGER PRIMARY KEY AUTOINCREMENT ,
						fa_cid INTEGER,	
						cname TEXT NOT NULL
					);";
					change(sql);

					sql = @"CREATE TABLE version(
						vid TEXT PRIMARY KEY NOT NULL,
						fa_vid TEXT,
						vname TEXT,
						introduction TEXT,
						submitter TEXT NOT NULL,
						create_time TimeStamp NOT NULL DEFAULT (datetime('now','localtime')),
						pid INTEGER NOT NULL
					);";
					change(sql);

					sql = @"CREATE TABLE project(
						pid INTEGER PRIMARY KEY AUTOINCREMENT ,
						pname TEXT NOT NULL,
						introduction TEXT,
						path TEXT NOT NULL,
						creator TEXT NOT NULL,
						create_time TimeStamp NOT NULL DEFAULT (datetime('now','localtime')),
						labels TEXT,
						head_vid TEXT,
						now_vid TEXT,
						cid INTEGER
					);";
					change(sql);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// 增删改，通过sql语句实现
		public void change(string sql)
		{
			try
			{
				using (con = new SQLiteConnection("Data Source=LocalDatabase.sqlite;Version=3;"))
				{
					con.Open();
					cmd = new SQLiteCommand(sql, con);
					cmd.ExecuteNonQuery();
					con.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		// 查询，通过返回值DataTable获得结果
		public System.Data.DataTable select(string sql)
		{
			try
			{
				using (con = new SQLiteConnection("Data Source=LocalDatabase.sqlite;Version=3;"))
				{
					con.Open();
					cmd = new SQLiteCommand(sql, con);
					SQLiteDataReader res = cmd.ExecuteReader();  // 获得结果
					System.Data.DataTable dataTable = new System.Data.DataTable();  // 结果转化
					dataTable.Load(res);
					con.Close();
					return dataTable;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			return null;
		}

		public static LocalDatabase getInstance()
		{
			return SingletonHolder.instance;
		}

		private static class SingletonHolder
		{
			public static LocalDatabase instance = new LocalDatabase();
		}
	}
}
