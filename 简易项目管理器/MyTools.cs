using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 简易项目管理器
{
	/*
	 * 工具类
	 * 功能：各类自己写的工具函数
	 * 说明：不需要实例化直接调用即可
	 * 编写人：陈登佳
	 */
	class MyTools
	{
		public static int getRandom(int maxValue)
		{
			return MyRandom.getRandom(maxValue);
		}

		public static int getRandom(int minValue, int maxValue)
		{
			return MyRandom.getRandom(minValue, maxValue);
		}

		public static string getRandomString(int length)
		{
			return MyRandom.getRandomString(length);
		}

		public static string path_use2save(string path)
		{
			string newPath = "";
			foreach (char c in path)
			{
				if (c == '\\')
					newPath += '/';
				else
					newPath += c;
			}
			return newPath;
		}

		public static string path_save2use(string path)
		{
			string newPath = "";
			foreach (char c in path)
			{
				if (c == '/')
					newPath += '\\';
				else
					newPath += c;
			}
			return newPath;
		}
	}

	/*
	 * 随机数类
	 * 功能：取100以内的随机数
	 * 说明：已经证实100以内的随机数的分布是均匀的
	 * 编写人：陈登佳
	 */

	class MyRandom
	{
		static Random rd = new Random();
		static int lastNum = rd.Next() * 13331;

		public static int getRandom(int maxValue)
		{
			DateTime dt = DateTime.Now;
			rd = new Random((int)(1L * lastNum * dt.Millisecond * 92083));
			lastNum = Math.Abs((int)(1L * rd.Next() * rd.Next() + 690163 * lastNum));
			lastNum %= 122777;
			return lastNum % maxValue;
		}

		public static int getRandom(int minValue, int maxValue)
		{
			lastNum = getRandom(maxValue - minValue + 1) + minValue;
			return lastNum;
		}

		public static string getRandomString(int length)
		{
			string charSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
			string randomID = "";

			for (int i = 0; i < length; i++)
			{
				randomID += charSet[getRandom(charSet.Length)];
			}
			return randomID;
		}






		// 测试单次取随机数
		public static void test(int limit, Chart chart)
		{
			int[] a = new int[1000];
			for (int i = 0; i < limit; i++)
				a[i] = 0;
			for (int i = 0; i < 10000; i++)
			{
				a[getRandom(limit)]++;
			}

			for (int i = 0; i < limit; i++)
				chart.Series["line1"].Points.AddY(a[i]);
		}

		public static void test2(int limit, Chart chart)
		{
			double[] b = new double[1000];
			for (int i = 0; i < limit; i++)
				b[i] = 0;

			for (int cnt = 0; cnt < limit; cnt++)
			{
				//System.Threading.Thread.Sleep(100);
				int[] a = new int[1000];
				for (int i = 0; i < limit; i++)
					a[i] = 0;
				for (int i = 0; i < 10000; i++)
				{
					a[getRandom(limit)]++;
				}
				for (int i = 0; i < limit; i++)
					b[i] += a[i];
			}

			for (int i = 0; i < limit; i++)
			{
				chart.Series["line1"].Points.AddY(b[i] / limit);
				Console.WriteLine(b[i] / limit);
			}
		}
	}
}
 