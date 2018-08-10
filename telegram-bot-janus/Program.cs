using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telegram_bot_janus {
	class Program {
		static void Main(string[] args) {
			if (args.Length == 3) {
				JanusBot janusBot = new JanusBot(databaseUser: args[0], databasePassword: args[1], databaseName: args[2]);
			}
		}
	}
}
