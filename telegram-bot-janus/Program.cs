using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace telegram_bot_janus {
	class Program {
		static void Main(string[] args) {
			if (args.Length == 3) {
				JanusBot janusBot = new JanusBot(databaseUser: args[0], databasePassword: args[1], databaseName: args[2]);
			} else {
				Console.WriteLine("Please enter your root database password:");
				string dBRootPw = Console.ReadLine();
				try {
					MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder {
						UserID = "root",
						Password = dBRootPw
					};
					MySqlConnection connection = new MySqlConnection(builder.GetConnectionString(true));
					connection.BeginTransaction();
					MySqlCommand command = connection.CreateCommand();
					command.CommandText = "";
					/*
					 check if database exists => try again
					 use random sha time thing for dbname, janusbot-afuckingshitton
					 create db and rows
					 get apikey
					 try it
					 put in db
					 profit
					 */
				} catch (MySqlException ex) {

				}
			}
		}
	}
}
