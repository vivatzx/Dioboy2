using Dioboy.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dioboy.ManagerBase
{
	class DioboyMainTrigger
	{
		private List<IDioBoyManager> _ManagerList = new List<IDioBoyManager>();

		private Thread _ManagerThread = null;

		public DioboyMainTrigger()
		{
			_ManagerList.Add(new AnniversaryManager());
			_ManagerList.Add(new MailManager());
			_ManagerList.Add(new PresentManager());
			_ManagerList.Add(new RestaurantManager());
		}

		public void Run()
		{
			_ManagerThread = new Thread(() =>
			{
				while (true)
				{
					try
					{
						DateTime now = DateTime.Now;

						foreach (var manager in _ManagerList)
						{
							manager.Run(now);
						}

						Thread.Sleep(10);
					}
					catch (ThreadAbortException e)
					{
						Debug.WriteLine(e.Message);
						break;
					}
				}
			});

			_ManagerThread.Start();
		}

		public void Stop()
		{
			if (null != _ManagerThread)
			{
				_ManagerThread.Abort();
			}
		}
	}
}
