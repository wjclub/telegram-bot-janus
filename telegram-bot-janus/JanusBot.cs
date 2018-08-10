using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace telegram_bot_janus {
	internal class JanusBot {
		public JanusBot(string databaseUser, string databasePassword, string databaseName) {
			dBHandler = new DBHandler(databaseUser: databaseUser, databasePassword: databasePassword, databaseName: databaseName);
			string[] apikeys = dBHandler.GetApikeys();
			foreach (string apikey in apikeys) {
				clients.Add(new TelegramBotClient(apikey), );
			}
		}
		DBHandler dBHandler;

		Dictionary<TelegramBotClient, int> clients = new Dictionary<TelegramBotClient, int>();

		internal async Task Run() {
			while (true) {
				foreach (TelegramBotClient client in clients) {
					client.GetUpdatesAsync();
				}
			}
		}
	}
}
