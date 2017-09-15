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
    public class clsListClient
    {

        private Dictionary<long, clsClient> myListClient = new Dictionary<long, clsClient>();

       public static DataTable tClient;

        public clsClient this[long index]
        {
            get
            {
                return this.myListClient[index];
            }
            set
            {
                this.myListClient[index] = value;
            }
        }


        public Dictionary<long, clsClient>.ValueCollection Users
        {
            get
            {
                return myListClient.Values;
            }
        }
        public int NumberOfClients
        {
            get
            {
                return myListClient.Count;
            }

        }
        public DataTable showAllClient()
        {

            Dataaccess.clsDataSource.mySet = new DataSet();
            Dataaccess.clsDataSource.Link();

            OleDbCommand mycom = new OleDbCommand("select * from Clients", Dataaccess.clsDataSource.myCon);
            clsDataSource.myAdpClient = new OleDbDataAdapter(mycom);

            clsDataSource.myAdpClient.Fill(clsDataSource.mySet, "Clients");
             tClient= Dataaccess.clsDataSource.mySet.Tables["Clients"];
            Dataaccess.clsDataSource.UnLink();
            return tClient;
        }
        public DataTable showspecificClients(long idAgent)
        {

            Dataaccess.clsDataSource.mySet = new DataSet();
            Dataaccess.clsDataSource.Link();

            OleDbCommand mycom = new OleDbCommand("select * from Clients where refAgent="+idAgent, Dataaccess.clsDataSource.myCon);
            clsDataSource.myAdpClient = new OleDbDataAdapter(mycom);

            clsDataSource.myAdpClient.Fill(clsDataSource.mySet, "Clients");
            tClient = Dataaccess.clsDataSource.mySet.Tables["Clients"];
            Dataaccess.clsDataSource.UnLink();
            return tClient;
        }

        public bool Find_user_pass(string username, string pass)
        {
            clsClient us = new clsClient();
            bool code = false;
            tClient = showAllClient();
            for (int current = 0; current < tClient.Rows.Count; current++)
            {

                if (username == tClient.Rows[current]["username"].ToString() && pass == tClient.Rows[current]["password"].ToString())
                {
                  
                    code = true;


                }

            }
            return code;
        }
        public clsClient Get_ID_user_pass(string username, string pass)
        {
            clsClient cl = new clsClient();

            tClient = showAllClient();
            for (int current = 0; current < tClient.Rows.Count; current++)
            {

                if (username == tClient.Rows[current]["username"].ToString() && pass == tClient.Rows[current]["password"].ToString())
                {
                    cl.TypeClient = tClient.Rows[current]["Type"].ToString().Trim();
                    cl.Username = tClient.Rows[current]["name"].ToString();
                    cl.Id = Convert.ToInt64(tClient.Rows[current]["ID"]);



                }

            }
            return cl;
        }

        public void Delete(int indx)
        {
           
            tClient.Rows[indx].Delete();

            // for deleting from database
            OleDbCommandBuilder mybuild = new OleDbCommandBuilder(clsDataSource.myAdpClient);
            mybuild.QuotePrefix = "[";
            mybuild.QuoteSuffix = "]";
            clsDataSource.myAdpClient.Update(tClient);

        }

        public void addToDB(DataRow row)
        {
            
            tClient.Rows.Add(row.ItemArray);
            //Save the content of the  Datatable to Dataset
            OleDbCommandBuilder myBuild = new OleDbCommandBuilder(clsDataSource.myAdpClient);
            myBuild.QuotePrefix = "[";
            myBuild.QuoteSuffix = "]";
            clsDataSource.myAdpClient.Update(tClient);
        }
        public void EditToDB(DataRow row)
        {
            
            OleDbCommandBuilder myBuild = new OleDbCommandBuilder(clsDataSource.myAdpClient);
            myBuild.QuotePrefix = "[";
            myBuild.QuoteSuffix = "]";
            clsDataSource.myAdpClient.Update(tClient);
        }
        public bool Add(clsClient aClient)
        {

            if (!Exist(aClient.Id))
            {
                myListClient.Add(aClient.Id, aClient);
                return true;
            }
            return false;
        }

        public bool Delete(long userId)
        {
            return myListClient.Remove(userId);
        }

        public bool Exist(long AnUser)
        {
        
            tClient = showAllClient();
            for (int current = 0; current < tClient.Rows.Count; current++)
            {

                if (AnUser.ToString() == tClient.Rows[current]["ID"].ToString())
                {
                    return true;

                }

            }
            return false;
        }

    }
}
