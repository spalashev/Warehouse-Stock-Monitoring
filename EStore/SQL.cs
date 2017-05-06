using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore
{
    public static class SQL
    {
        private static string _strCurrentConnection;

        public static string Connection
        {
            get { return _strCurrentConnection; }
            set { _strCurrentConnection = value; }
        }

        public static DataTable SqlExec(string strQuery)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlCon = new SqlConnection(Connection);
            SqlCommand sqlCmd = new SqlCommand(strQuery, sqlCon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCmd);

            try
            {
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception)
            {
                dt.Clear();
                return dt;
            }
            sqlCon.Close();
            return dt;
        }       
    }
    public static class EntityFrameworkTransactionsControl
    {
        public static void Commit(DbContext context)
        {
            context.SaveChanges();
        }

        public static void Rollback(DbContext context)
        {
            var changedEntries = context.ChangeTracker.Entries()
                                                                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }
    }
}
