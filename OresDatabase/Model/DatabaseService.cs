using Microsoft.Data.Sqlite;
using OresDatabase.Model.Attributes;
using System.Data.Common;
using System.Reflection;

namespace OresDatabase.Model
{
    internal class DatabaseService
    {
        private Database _database;

        public DatabaseService(Database database)
        {
            _database = database;
        }

        public void Get<T>(string expression) where T : new()
        {
            using (SqliteDataReader reader = _database.GetReader(expression))
            {
                var t = new T();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var r = reader.GetColumnSchema();//!!!
                        FieldInfo[] fieldInfoList = typeof(T).GetFields();
                        foreach (FieldInfo fieldInfo in fieldInfoList)
                        {
                            var rr = fieldInfo.GetCustomAttribute<FieldNameAttribute>().FieldName;//!!!
                        }
                        

                        var id = reader.GetValue(0);
                        var name = reader.GetValue(1);
                        var age = reader.GetValue(2);
                    }
                }
            }
        }
    }
}
