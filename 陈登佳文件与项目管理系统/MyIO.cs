using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 陈登佳文件与项目管理系统
{
	class MyIO
	{
		
		/// <summary>
		/// 复制文件夹及文件
		/// </summary>
		/// <param name="sourceFolder">原文件路径</param>
		/// <param name="destFolder">目标文件路径</param>
		/// <returns></returns>
		public static int CopyFolder(string sourceFolder, string destFolder, string ignoreFolder="")
		{
			try
			{
				//如果目标路径不存在,则创建目标路径
				if (!System.IO.Directory.Exists(destFolder))
				{
					System.IO.Directory.CreateDirectory(destFolder);
				}
				//得到原文件根目录下的所有文件
				string[] files = System.IO.Directory.GetFiles(sourceFolder);
				foreach (string file in files)
				{
					string name = System.IO.Path.GetFileName(file);
					string dest = System.IO.Path.Combine(destFolder, name);
					System.IO.File.Copy(file, dest);//复制文件
				}
				//得到原文件根目录下的所有文件夹
				string[] folders = System.IO.Directory.GetDirectories(sourceFolder);
				foreach (string folder in folders)
				{
					string name = System.IO.Path.GetFileName(folder);
					if (!string.IsNullOrEmpty(ignoreFolder) && name.Equals(ignoreFolder))  // 忽略某个文件
						continue;
					string dest = System.IO.Path.Combine(destFolder, name);
					CopyFolder(folder, dest);//构建目标路径,递归复制文件
				}
				return 1;
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
				return 0;
			}
		}

		public static void DeleteAll(string aimFolder, string ignoreFolder)
		{
			try
			{
				//如果目标路径不存在,则结束
				if (!System.IO.Directory.Exists(aimFolder))
					return;

				//得到原文件根目录下的所有文件
				string[] files = System.IO.Directory.GetFiles(aimFolder);
				foreach (string file in files)
				{
					System.IO.File.Delete(file);//删除文件
				}
				//得到原文件根目录下的所有文件夹
				string[] folders = System.IO.Directory.GetDirectories(aimFolder);
				foreach (string folder in folders)
				{
					string name = System.IO.Path.GetFileName(folder);
					if (!string.IsNullOrEmpty(ignoreFolder) && name.Equals(ignoreFolder))  // 忽略某个文件
						continue;
					DirectoryInfo di = new DirectoryInfo(folder);
					di.Delete(true);
				}
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}
	}
}
