using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webaddressbooktests
{
   public class ContactData
    { 
        private string name ="";
        private string lname ="";
        private string nick = "";
        private string comp = "";
        private string home = "";
        private string place = "";
       

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Lname
        {
            get 
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public string Nick
        {
            get
            {
                return nick;
            }
            set
            {
                nick = value;
            }
        }

        public string Comp
        {
            get
            {
                return comp;
            }
            set
            {
                comp = value;
            }
        }

        public string Hom
        {
            get
            {
                return home;
            }
            set
            {
                home = value;
            }
        }

        public string Place
        {
            get
            {
                return place;
            }
            set
            {
                place = value;
            }
        }
    }
}
