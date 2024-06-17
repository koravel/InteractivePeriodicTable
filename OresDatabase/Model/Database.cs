using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OresDatabase.Model
{
    internal class Database
    {
        private ConfigurationLib.Configuration _config;
        private SqliteConnection _connection;

        public Database(ConfigurationLib.Configuration config)
        {
            _config = config;
            //_connection = new SqliteConnection(_config.GetValueOrThrow<string>("sqlite-connection"));

            InitDb();
        }

        public SqliteDataReader GetReader(string expression)
        {
            using (var connection = new SqliteConnection(_config.GetValueOrThrow<string>("sqlite-connection")))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(expression);
                command.Connection = connection;

                return command.ExecuteReader();
            }
        }

        private void InitDb()
        {
            using (var connection = new SqliteConnection(_config.GetValueOrThrow<string>("sqlite-connection")))
            {
                connection.Open();

                string commandText = File.ReadAllText(_config.GetValueOrThrow<string>("sqlite-db-init-script-location"));
                foreach (string commandString in GetCommands(commandText))
                {
                    if (commandString.Trim() != "")
                    {
                        try
                        {
                            new SqliteCommand(commandString, connection).ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        private IEnumerable<string> GetCommands(string commandText)
        {
            IEnumerable<string> commandStrings = Regex.Split(commandText, @"^\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            List<string> result = new List<string>();
            foreach (var commandString in commandStrings)
            {
                var formattedCommandString = commandString.Replace("\t", "").Replace("\r", "").Replace("\n", "");
                result.Add(formattedCommandString);
            }

            return result;
        }
    }
}
