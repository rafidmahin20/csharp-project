using System.Data;
using System.Data.SqlClient;

namespace FoodMart
{
    internal class DataAccess
    {
        public static SqlConnection sqlCon;

        public static SqlConnection SqlCon
        {
            get
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection("Data Source=RAFID;Initial Catalog=FoodShop;Persist Security Info=True;User ID=sa;Password=rafid 20");
                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                return sqlCon;
            }
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqlCom = new SqlCommand(query, SqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        public static int ExecuteDmlQuery(string query)
        {
            SqlCommand sqlCom = new SqlCommand(query, SqlCon);
            return sqlCom.ExecuteNonQuery();
        }
    }
}