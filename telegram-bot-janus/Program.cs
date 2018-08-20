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
				Console.WriteLine("Enter your database server address now (or leave empty for 127.0.0.1):");
				string dBServerAdress = Console.ReadLine();
				if (string.IsNullOrEmpty(dBServerAdress)) {
					dBServerAdress = "127.0.0.1";
				}
				try {
					MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder {
						Server = dBServerAdress,
						UserID = "root",
						Password = dBRootPw
					};
					MySqlConnection connection = new MySqlConnection(builder.GetConnectionString(true));
					try {
						connection.Open();
					} catch (MySqlException ex) {
						Console.WriteLine("An error occured with the database, try again?\nException: \n\n" + ex.ToString());
						return;
					}
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
