using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dioboy.DB
{
	class DBManager
	{
		private static volatile DBManager _Instance = null;
		private static object _SyncRoot = new Object();

		private DioboyDBEntities _DB = new DioboyDBEntities();

		public static DBManager Instance
		{
			get
			{
				if (null == _Instance)
				{
					lock (_SyncRoot)
					{
						if (null == _Instance)
						{
							_Instance = new DBManager();
						}
					}
				}

				return _Instance;
			}
		}

		private DBManager() { }
	}
}
