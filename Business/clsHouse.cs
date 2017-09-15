using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business

{
    public class clsHouse
    {
        private string houseType;

        public string HouseType
        {
            get { return houseType; }
            set { houseType = value; }
        }
        private long houseID;

        public long HouseID
        {
            get { return houseID; }
            set { houseID = value; }
        }
        private string houseAddress;

        public string HouseAddress
        {
            get { return houseAddress; }
            set { houseAddress = value; }
        }
        private string location;

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private long houseSize;

        public long HouseSize
        {
            get { return houseSize; }
            set { houseSize = value; }
        }
        private int nbRoom;

        public int NbRoom
        {
            get { return nbRoom; }
            set { nbRoom = value; }
        }

        private bool pool;

        public bool Pool
        {
            get { return pool; }
            set { pool = value; }
        }
        private decimal housePrice;

        public decimal HousePrice
        {
            get { return housePrice; }
            set { housePrice = value; }
        }

        private long agentId;

        public long AgentId
        {
            get { return agentId; }
            set { agentId = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public clsHouse(long houseID, string houseType, string houseAddress, string location, long houseSize, decimal housePrice, int nbRoom, bool pool,string status, long agentId)
        {
            this.houseID = houseID;
            this.houseType = houseType;            
            this.houseAddress = houseAddress;
            this.location = location;
            this.houseSize = houseSize;
            this.housePrice = housePrice;
            this.nbRoom = nbRoom;
            this.pool = pool;
            this.status = status;
            this.AgentId = agentId;
        }
        public clsHouse()
        {

            this.houseType = "";
            this.houseAddress ="";
            this.location = "";
            this.houseSize = 0;
            this.housePrice = 0;
            this.nbRoom = 0;
            this.pool = false;
            this.status = "";
            this.AgentId = 0;
        }

    }
}
