using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dataaccess;
using System.Data;
using System.Data.OleDb;

namespace Business
{
     public class clsListUser
    {
        private Dictionary<long, clsUser> myListUser = new Dictionary<long, clsUser>();

        public static DataTable tUser;
        public static DataView vAgents;
        public static DataRow agentRow;
       DataSet set=Dataaccess.clsDataSource.mySet;

        public clsUser this[long index]
        {
            get
            {
                return this.myListUser[index];
            }
            set
            {
                this.myListUser[index] = value;
            }
        }


        public Dictionary<long, clsUser>.ValueCollection Users
        {
            get
            {
                return myListUser.Values;
            }
        }

        public int NumberOfAgents
        {
            get
            {
                return myListUser.Count;
            }

        }
        public  DataTable showAllUser()
        {
            
           Dataaccess.clsDataSource.mySet = new DataSet();
            Dataaccess.clsDataSource.Link();

            OleDbCommand mycom = new OleDbCommand("select * from Users" , Dataaccess.clsDataSource.myCon);
           // mycom.Connection=
            Dataaccess.clsDataSource.myAdpUser = new OleDbDataAdapter(mycom);

            Dataaccess.clsDataSource.myAdpUser.Fill(Dataaccess.clsDataSource.mySet, "Users");
           tUser = Dataaccess.clsDataSource.mySet.Tables["Users"];
            Dataaccess.clsDataSource.UnLink();
            return tUser;
        }
        public DataView showAgents()
        {
            //showAllUser();
            vAgents = new DataView(tUser) ;
            vAgents.Sort = "ID ASC";
            vAgents.RowFilter = "Type='agents'";
            return vAgents;


        }
        public DataView showAnAgent(long id)
        {
            vAgents = new DataView(tUser);
            vAgents.Sort = "ID ASC";
            vAgents.RowFilter = "ID="+id+ " and Type='agents'";
            return vAgents;
        }
        public clsUser emailAgents(Int64 id)
        {
            clsUser us = new clsUser();
            
            tUser = showAllUser();
            for (int current = 0; current < tUser.Rows.Count; current++)
            {

                if (id.ToString() == tUser.Rows[current]["ID"].ToString())
                {

                    us.TypeUser = tUser.Rows[current]["Type"].ToString().Trim();
                    us.Name = tUser.Rows[current]["name"].ToString();
                    us.Id = Convert.ToInt64(tUser.Rows[current]["ID"]);
                    us.Email= tUser.Rows[current]["email"].ToString();
                    
                   

                }

            }
            return us;
    
        }
        public DataView showAnAgent(string name)
        {
            vAgents = new DataView(tUser);
            vAgents.Sort = "ID ASC";
            vAgents.RowFilter = "name='" + name + "' and Type='agents'";
            return vAgents;
        }



        public DataRow showNameAgents()
        {
            tUser = showAllUser();
            foreach (DataRow myrow in tUser.Rows)
            {
                if (myrow["Type"].ToString() == "agents")
                {
                    return myrow;
                }

            }


            return null;
        }

        public DataRow[] nameAgents(long id)
        {
            tUser = showAllUser();
          
                DataRow[] agentRowName = tUser.Select("ID=" + id);

           



            return agentRowName;


        }
        public bool Add(clsUser aUser)
        {

            if (!Exist(aUser.Id))
            {
                myListUser.Add(aUser.Id, aUser);
                return true;
            }
            return false;
        }

        public bool Delete(long userId)
        {
            return myListUser.Remove(userId);
        }

        public bool Exist(long AnUser)
        {
          
           tUser= showAllUser();
            for (int current = 0; current < tUser.Rows.Count; current++)
            {

                if (AnUser.ToString() == tUser.Rows[current]["ID"].ToString() )
                {
                    return true;

                }

            }
            return false;
        }
      
        public bool Find_user_pass(string username,string pass)
        {
            clsUser us = new clsUser();
            bool code = false;
            tUser = showAllUser();
            for (int current = 0; current < tUser.Rows.Count; current++)
            {

                if (username == tUser.Rows[current]["userName"].ToString() && pass == tUser.Rows[current]["password"].ToString())
                {
                   us.TypeUser = tUser.Rows[current]["Type"].ToString().Trim();
                    us.Name = tUser.Rows[current]["name"].ToString();
                    us.Id = Convert.ToInt64(tUser.Rows[current]["ID"]);
                    code = true;
                   

                }
                
            }
            return code;
        }
        public clsUser Get_ID_user_pass(string username, string pass)
        {
            clsUser us = new clsUser();
          
            tUser = showAllUser();
            for (int current = 0; current < tUser.Rows.Count; current++)
            {

                if (username == tUser.Rows[current]["userName"].ToString() && pass == tUser.Rows[current]["password"].ToString())
                {
                    us.TypeUser = tUser.Rows[current]["Type"].ToString().Trim();
                    us.Name = tUser.Rows[current]["name"].ToString().Trim();
                    us.Id = Convert.ToInt64(tUser.Rows[current]["ID"]);

                    

                }

            }
            return us;
        }
       

        public clsUser Find(long userId)
        {
            clsUser us = new clsUser();
            if (Exist(userId))
            {
                return myListUser[userId];
            }
            return null;
        }
        public void Delete(int indx)
        {
            
            tUser.Rows[indx].Delete();

            // for deleting from database
            OleDbCommandBuilder mybuild = new OleDbCommandBuilder(clsDataSource.myAdpUser);
            mybuild.QuotePrefix = "[";
            mybuild.QuoteSuffix = "]";
            clsDataSource.myAdpUser.Update(tUser);

        }

        public void addToDB(DataRow row)
        {
          
            tUser.Rows.Add(row.ItemArray);
            //Save the content of the  Datatable to Dataset
            OleDbCommandBuilder myBuild = new OleDbCommandBuilder(clsDataSource.myAdpUser);
            myBuild.QuotePrefix = "[";
            myBuild.QuoteSuffix = "]";
            clsDataSource.myAdpUser.Update(tUser);
        }
        public void EditToDB(DataRow row)
        {
           
            OleDbCommandBuilder myBuild = new OleDbCommandBuilder(clsDataSource.myAdpUser);
            myBuild.QuotePrefix = "[";
            myBuild.QuoteSuffix = "]";
            clsDataSource.myAdpUser.Update(tUser);
        }

    }
}
