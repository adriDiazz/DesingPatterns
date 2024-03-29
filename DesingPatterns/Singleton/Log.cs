﻿using System;
namespace DesingPatterns.Singleton
{
	public class Log
	{
		private readonly static Log _instance = new Log();
		private string _path = "log.txt";

		public static Log Logger
		{
			get
			{
				return _instance;
			}
		}

		private Log()
		{
		}

		public void Save(string message)
		{
			File.AppendAllText(_path, message + Environment.NewLine);
		}
	}
}

