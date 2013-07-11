using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dioboy.Manager
{
	class MailManager : IDioBoyManager
	{
		public enum EnManagerError
		{
			None,
		};

		protected EnManagerError SendMail(string data)
		{
			return EnManagerError.None;
		}

		protected EnManagerError ReceiveMail(out string result)
		{
			result = "";

			return EnManagerError.None;
		}

		public int Run(DateTime tick)
		{
			//throw new NotImplementedException();

			return 0;
		}
	}
}
