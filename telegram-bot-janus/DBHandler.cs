using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace telegram_bot_janus {
	internal class DBHandler {
		public DBHandler(string databaseUser, string databasePassword, string databaseName) {
			
		}

		internal string[] GetApikeys() => new string[]{ "" };
	}
}
