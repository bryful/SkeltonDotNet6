using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeltonDotNet6
{
	public class PrefFile
	{
		JsonFile JsonFile { get; set; } = new JsonFile();
		// *********************************
		private string m_AppName = "";
		public string AppName { get { return m_AppName; } }
		// *********************************
		private string m_AppDataPath = "";
		public string AppDataPath { get { return m_AppDataPath; } }
		private string m_AppDataDirectory = "";
		public string AppDataDirectory { get { return m_AppDataDirectory; } }
		public PrefFile()
		{
			m_AppName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
			m_AppDataDirectory = GetAppDataPath();
			m_AppDataPath = Path.Combine(m_AppDataDirectory, m_AppName + ".json");

		}

		// ****************************************************
		static public string GetAppDataPath()
		{
			return GetFileSystemPath(Environment.SpecialFolder.ApplicationData);
		}
		// ****************************************************
		static public string GetFileSystemPath(Environment.SpecialFolder folder)
		{
			// パスを取得
			string path = String.Format(@"{0}\{1}",//\{2}
			  Environment.GetFolderPath(folder),  // ベース・パス
												  //Application.CompanyName,            // 会社名
			  Application.ProductName
			  );           // 製品名

			// パスのフォルダを作成
			lock (typeof(Application))
			{
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
			}
			return path;
		}
		// ****************************************************
		static public bool IsInRect(Rectangle a, Rectangle b)
		{
			bool ret = true;

			if ((a.Left > b.Left + b.Width) || (a.Left + a.Width < b.Left))
			{
				ret = false;
			}
			if ((a.Top > b.Top + b.Height) || (a.Top + a.Height < b.Top))
			{
				ret = false;
			}
			return ret;
		}
		// ****************************************************
		static public bool ScreenIn(Rectangle? rct)
		{
			bool ret = false;
			if (rct == null) return ret;
			foreach (Screen s in Screen.AllScreens)
			{
				Rectangle r = s.WorkingArea;
				if (IsInRect(r, (Rectangle)rct))
				{
					ret = true;
					break;
				}
			}
			return ret;
		}
		// ****************************************************
		static public Rectangle NowScreen(Rectangle rct)
		{
			Rectangle ret = new Rectangle(0, 0, 0, 0);
			foreach (Screen s in Screen.AllScreens)
			{
				Rectangle r = s.WorkingArea;
				if (IsInRect(r, rct))
				{
					ret = r;
					break;
				}
			}
			return ret;
		}
		// ****************************************************
		static public bool ScreenIn(Point p, Size sz)
		{
			return ScreenIn(new Rectangle(p, sz));
		}
	}
}
