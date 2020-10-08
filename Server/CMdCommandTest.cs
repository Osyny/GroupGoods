using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{

    public class CMdCommandTest
    {
        private DbConnection connection;
        private DbDataReader reader;
        public bool isReadStopEvent;

        public CMdCommandTest Init(DbConnection connection)
        {
            this.connection = connection;
            return this;
        }
        public CMdCommandTest Open()
        {
            connection.Open();
            return this;
        }
        public void PerformCmd(string cmd)
        {
            if (this.reader != null && !this.reader.IsClosed)
            {
                this.reader.Close();
                this.reader = null;
            }

            if (this.connection.State == ConnectionState.Closed)
            {
                this.connection.OpenAsync();
            }

            var command = connection.CreateCommand();
            command.CommandText = cmd;
            this.reader = command.ExecuteReader();
        }

        public void GetRecords(Action<IDataRecord> callback)
        {
            this.isReadStopEvent = false;
            while (this.reader.Read() && this.isReadStopEvent == false)
            {
                callback(this.reader);
            }
            this.isReadStopEvent = false;
        }

        public void Close()
        {
            if (!this.reader.IsClosed)
            {
                this.reader.Close();
            }
            this.connection.Close();
        }
    }


    public class CommonCMdFac
    {
        //AllCasesRegisteredCountView
        //AllClientsCountView
        public static string SelectMaterializedView(string viewName)
        {
            return $"SELECT * FROM \"{viewName}\"";
        }


        public static string UpdateMaterializedView(string viewName)
        {
            return $"REFRESH MATERIALIZED VIEW \"{viewName}\"";
        }

        public static string ClientsIdByNameILike(string queryNormalized)
        {
            return $"select client.\"Id\" FROM \"Clients\" AS client WHERE client.\"FirstName\" ILIKE \'%{queryNormalized}%\' OR client.\"Surname\" ILIKE \'%{queryNormalized}%\' OR client.\"FatherName\" ILIKE \'%{queryNormalized}%\';";
        }
        public static string ClientsIdByNameFullMatch(string queryNormalized)
        {
            return $"select client.\"Id\" FROM \"Clients\" AS client where lower(client.\"FirstName\") = '{queryNormalized}' or lower(client.\"Surname\") = '{queryNormalized}' or lower(client.\"FatherName\") = '{queryNormalized}';";
        }

        public static string GetIds(bool isFialdId, string field, string table, Guid parentId)
        {
            if (isFialdId)
            {
                var res = $"SELECT \"{field}\" FROM \"{table}\" WHERE \"Id\" = \'{parentId}\'";
                return res;
            }
            var res2 = $"SELECT * FROM \"{table}\" WHERE \"{field}Id\" = \'{parentId}\'";
            return res2;
        }

        // ---------------------------------------------------------------------

        public static string GetGroup(string selectStr)
        {

            var lisrSelect = selectStr.Split(',');
            var select = string.Join("\", ", lisrSelect);
           // var lisrGroup = groupStr.Split(',');
          //  var group = string.Join("\", ", lisrGroup);


            var res = $"{selectStr}";

            return res;

        }
    }
}