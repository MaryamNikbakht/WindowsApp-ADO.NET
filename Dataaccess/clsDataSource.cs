using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;


namespace Dataaccess
{
   public static class clsDataSource
    {
        public static string myPath;
        public static OleDbConnection myCon;
        public static OleDbDataAdapter myAdpMSG;
        public static OleDbDataAdapter myAdpUser;
        public static OleDbDataAdapter myAdpHouse;

        public static OleDbDataAdapter myAdpClient;
      public static DataSet mySet;
        //==============================================================

       
      

        public static void Link()
        {
            myPath = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Mary\\Documents\\GitHub\\prjRemax\\prjRemax\\App_Data\\RemaxDB.mdb";
            myCon = new OleDbConnection(myPath);
              myCon.Open();
            


        }

        public static void UnLink()
        {
            myCon.Close();
          
        }

    


    }
}
