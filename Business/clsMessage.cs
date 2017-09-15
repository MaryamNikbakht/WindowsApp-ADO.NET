using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public class clsMessage
    {
        private long refMessage;
        private string title;
        private string message;
        private string senderEmail;
        private long reciever;
        private DateTime date;
        public long RefMessage
        {
            get { return refMessage; }
            set { refMessage = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public string SenderEmail
        {
            get { return senderEmail; }
            set { senderEmail = value; }
        }
        public long Reciever
        {
            get { return reciever; }
            set { reciever = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public clsMessage(long refMessage,string title, string message, string senderEmail,long reciever, DateTime date)
           
        {
            this.refMessage = refMessage;
            this.title = title;
            this.message = message;
            this.senderEmail = senderEmail;
            this.reciever = reciever;
            this.date = date;
          
        }
        public clsMessage()
        {
            this.refMessage =-1;
            this.title = "";
            this.message = "";
            this.senderEmail = "";
            this.reciever = -1;
            this.date = DateTime.Today;
        }


     
    }
}
