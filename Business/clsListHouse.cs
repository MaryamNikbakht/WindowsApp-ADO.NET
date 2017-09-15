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
    public class clsListHouse
    {

        private Dictionary<long, clsHouse> myListHouses = new Dictionary<long, clsHouse>();

        public static DataTable tHouse;
        public static DataView vHouse;
        public clsHouse this[long index]
        {
            get
            {
                return this.myListHouses[index];
            }
            set
            {
                this.myListHouses[index] = value;
            }
        }

        public Dictionary<long, clsHouse>.ValueCollection Houses
        {
            
            get
            {
               
                return myListHouses.Values;
            }
        }

       
        public int NbOfHouses
        {
            get
            {
                return myListHouses.Count;
            }
        }

        public  DataTable showAllHouse()
        {

            Dataaccess.clsDataSource.mySet = new DataSet();
            Dataaccess.clsDataSource.Link();

            OleDbCommand mycom = new OleDbCommand("select * from House", Dataaccess.clsDataSource.myCon);
            clsDataSource.myAdpHouse = new OleDbDataAdapter(mycom);

            clsDataSource.myAdpHouse.Fill(clsDataSource.mySet, "House");
            tHouse = Dataaccess.clsDataSource.mySet.Tables["House"];
            Dataaccess.clsDataSource.UnLink();
            return tHouse;
        }
        public DataTable showSpecificHouse(long refAgent)
        {

            Dataaccess.clsDataSource.mySet = new DataSet();
            Dataaccess.clsDataSource.Link();

            OleDbCommand mycom = new OleDbCommand("select * from House where ReferAgent="+refAgent, Dataaccess.clsDataSource.myCon);
            clsDataSource.myAdpHouse = new OleDbDataAdapter(mycom);

            clsDataSource.myAdpHouse.Fill(clsDataSource.mySet, "House");
            tHouse = Dataaccess.clsDataSource.mySet.Tables["House"];
            Dataaccess.clsDataSource.UnLink();
            return tHouse;
        }



        public DataView showAHouse(long id)
        {
            vHouse = new DataView(tHouse);
            vHouse.Sort = "RefHouse ASC";
            vHouse.RowFilter = "RefHouse=" + id ;
            return vHouse;
        }
     
        public clsHouse getHouses(int current)
        {
            clsListUser agents = new clsListUser();
            clsHouse house;

            long houseId = Convert.ToInt64(tHouse.Rows[current]["RefHouse"]);
            string type = tHouse.Rows[current]["HouseType"].ToString();
            string address = tHouse.Rows[current]["HouseNumber"].ToString();

            //***************************************
            long refAgent = Convert.ToInt64(tHouse.Rows[current]["ReferAgent"]);

            DataRow[] agentRowName = agents.showAllUser().Select("ID=" + refAgent);

            string nameAgent = agentRowName[0]["name"].ToString();


            string houseStatus = tHouse.Rows[current]["Status"].ToString();
            //***************************************

            string location = tHouse.Rows[current]["Location"].ToString();
            decimal price = Convert.ToDecimal(tHouse.Rows[current]["Price"]);
            long size = Convert.ToInt64(tHouse.Rows[current]["Surface"]);
            int nbRoom = Convert.ToInt32(tHouse.Rows[current]["NbRooms"]);
            bool pool = Convert.ToBoolean(tHouse.Rows[current]["Pool"]);

        

            house = new clsHouse(houseId, type, address, location, size, price, nbRoom, pool, houseStatus, refAgent);
            myListHouses.Add(house.HouseID,house);
            //TextToList(houseId);
            return house;
        }
        public void addToDB(DataRow row)
        {
            tHouse.Rows.Add(row);
            //Save the content of the  Datatable to Dataset
            OleDbCommandBuilder myB = new OleDbCommandBuilder(clsDataSource.myAdpHouse);
            clsDataSource.myAdpHouse.Update(tHouse);
        }
        public void EditToDB(DataRow row)
        {
            OleDbCommandBuilder myB = new OleDbCommandBuilder(clsDataSource.myAdpHouse);
            clsDataSource.myAdpHouse.Update(tHouse);
        }
        public bool Add(clsHouse aHouse)
        {
            if (!Exist(aHouse.HouseID))
            {
                myListHouses.Add(aHouse.HouseID, aHouse);
                return true;
            }
            return false;
        }

        public void Delete(int indx)
        {
            // return myListHouses.Remove(houseId);
            tHouse.Rows[indx].Delete();

            // for deleting from database
            OleDbCommandBuilder mybuild = new OleDbCommandBuilder(clsDataSource.myAdpHouse);
            clsDataSource.myAdpHouse.Update(tHouse);
            
        }

        public bool Exist(long houseId)
        {
            return myListHouses.ContainsKey(houseId);
        }

        public clsHouse Find(long houseId)
        {
            if (Exist(houseId))
            {
                return myListHouses[houseId];
            }
            return null;
        }
        public DataTable get_allHouses()
        {
            tHouse = showAllHouse();
            return tHouse;
        }


    }
}
