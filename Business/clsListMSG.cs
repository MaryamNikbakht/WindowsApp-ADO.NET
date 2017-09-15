using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dataaccess;
using System.Data;
using System.Data.OleDb;

namespace Business
{
    public class clsListMSG
    {
        private List<clsMessage> myListMSG = new List<clsMessage>();

        public static DataTable tMSG;
        public static DataView vMSG;
        public static DataRow msgtRow;
        DataSet set = Dataaccess.clsDataSource.mySet;

        public bool Add(clsMessage aMsg)
        {

            if (!Exist(aMsg.RefMessage))
            {
                myListMSG.Add(aMsg);
                return true;
            }
            return false;
        }
        public bool Exist(long AMSG)
        {

            tMSG = showAllMSG();
            for (int current = 0; current < tMSG.Rows.Count; current++)
            {

                if (AMSG.ToString() == tMSG.Rows[current]["RefMessage"].ToString())
                {
                    return true;

                }

            }
            return false;
        }

        public DataTable showAllMSG()
        {

            Dataaccess.clsDataSource.mySet = new DataSet();
            Dataaccess.clsDataSource.Link();

            OleDbCommand mycom = new OleDbCommand("select * from Messeges", Dataaccess.clsDataSource.myCon);
           
            Dataaccess.clsDataSource.myAdpMSG = new OleDbDataAdapter(mycom);

            Dataaccess.clsDataSource.myAdpMSG.Fill(Dataaccess.clsDataSource.mySet, "Messeges");
            tMSG = Dataaccess.clsDataSource.mySet.Tables["Messeges"];
            Dataaccess.clsDataSource.UnLink();
            return tMSG;
        }

        public void addToDB(DataRow row)
        {
            
            tMSG.Rows.Add(row.ItemArray);
            //Save the content of the  Datatable to Dataset
            OleDbCommandBuilder myBuild = new OleDbCommandBuilder(clsDataSource.myAdpMSG);
            myBuild.QuotePrefix = "[";
            myBuild.QuoteSuffix = "]";
            clsDataSource.myAdpMSG.Update(tMSG);
        }
    }
}
