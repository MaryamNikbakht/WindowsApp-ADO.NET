using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsPerson
    {

        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
   
      

        public clsPerson(long id,string name)
        {
            this.id = id;
            this.name = name;
           
        }

        public clsPerson()
        {
            this.id = -1;
            this.name = "";          
            
        }

    }
}
