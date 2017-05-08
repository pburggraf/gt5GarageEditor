using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GT5_Garage_Editor.Utils
{
    public sealed class SqlHelper
    {
        private readonly string _dataSource;
        private readonly byte[] _passwordBytes;

        public SqlHelper()
        {
            _dataSource = "Data Source=woops.s3db";
            _passwordBytes = null;
        }

        public SqlHelper(string source, bool isEnc, byte[] passBytes)
        {
            try
            {
                _dataSource = string.Format("Data Source={0}", source + @"");
                if (!isEnc)
                    return;
                _passwordBytes = new byte[passBytes.Length];
                Array.Copy(passBytes, _passwordBytes, passBytes.Length);
            }
            catch
            {
            }
        }

        public SqlHelper(Dictionary<string, string> dictionary_0)
        {
            var str = string.Empty;
            foreach (var keyValuePair in dictionary_0)
                str = str + string.Format("{0}={1}; ", keyValuePair.Key, keyValuePair.Value);
            _dataSource = str.Trim().Substring(0, str.Length - 1);
        }

        public DataTable ExecuteReader(string query)
        {
            var dataTable = new DataTable();
            try
            {
                var connection = new SQLiteConnection(_dataSource);
                if (_passwordBytes != null)
                    connection.SetPassword(_passwordBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection) { CommandText = query };
                var sqLiteDataReader = sqLiteCommand.ExecuteReader();
                dataTable.Load(sqLiteDataReader);
                sqLiteDataReader.Close();
                connection.Close();
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 200");
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string string_1)
        {
            try
            {
                var connection = new SQLiteConnection(_dataSource);
                if (_passwordBytes != null)
                    connection.SetPassword(_passwordBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                sqLiteCommand.CommandText = string_1;
                var num = sqLiteCommand.ExecuteNonQuery();
                connection.Close();
                return num;
            }
            catch
            {
                return 0;
            }
        }

        public string ExecuteScalar(string string_1)
        {
            try
            {
                var connection = new SQLiteConnection(_dataSource);
                if (_passwordBytes != null)
                    connection.SetPassword(_passwordBytes);
                connection.Open();
                var sqLiteCommand = new SQLiteCommand(connection);
                sqLiteCommand.CommandText = string_1;
                var obj = sqLiteCommand.ExecuteScalar();
                connection.Close();
                return obj != null ? obj.ToString() : string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public bool Update(string string_1, Dictionary<string, string> dictionary_0, string string_2)
        {
            var str = string.Empty;
            var flag = true;
            if (dictionary_0.Count >= 1)
            {
                foreach (var keyValuePair in dictionary_0)
                    str = str + string.Format(" {0} = '{1}',", keyValuePair.Key, keyValuePair.Value);
                str = str.Substring(0, str.Length - 1);
            }
            try
            {
                ExecuteNonQuery(string.Format("update {0} set {1} where {2};", string_1, str, string_2));
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        public bool DeleteFromWhere(string string_1, string string_2)
        {
            var flag = true;
            try
            {
                ExecuteNonQuery(string.Format("delete from {0} where {1};", string_1, string_2));
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 200");
                flag = false;
            }
            return flag;
        }

        public bool InsertInto(string string_1, Dictionary<string, string> dictionary_0)
        {
            var str1 = string.Empty;
            var str2 = string.Empty;
            var flag = true;
            foreach (var keyValuePair in dictionary_0)
            {
                str1 = str1 + string.Format(" {0},", keyValuePair.Key);
                str2 = str2 + string.Format(" '{0}',", keyValuePair.Value);
            }
            var str3 = str1.Substring(0, str1.Length - 1);
            var str4 = str2.Substring(0, str2.Length - 1);
            try
            {
                ExecuteNonQuery(string.Format("insert into {0}({1}) values({2});", string_1, str3, str4));
            }
            catch
            {
                var num = (int)MessageBox.Show("Something went wrong: Error 200");
                flag = false;
            }
            return flag;
        }

        public bool DeleteAll()
        {
            try
            {
                foreach (DataRow dataRow in (InternalDataCollectionBase)ExecuteReader("select NAME from SQLITE_MASTER where type='table' order by NAME;").Rows)
                    Delete(dataRow["NAME"].ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string string_1)
        {
            try
            {
                ExecuteNonQuery(string.Format("delete from {0};", string_1));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
