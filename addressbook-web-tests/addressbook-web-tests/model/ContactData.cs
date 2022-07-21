using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webaddressbooktests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string fname = "";
        private string lname = "";
        private string nick = "";
        private string comp = "";
        private string home = "";
        private string place = "";

        public ContactData(string fname , string lname)
        {
            Fname = fname;
            Lname = lname;
        }

        public ContactData()
        {
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            return Fname == other.Fname && 
                   Lname == other.Lname;

         }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Fname.CompareTo(other.Fname);
        }
        public override int GetHashCode()
        {

            return Fname.GetHashCode() +
                Lname.GetHashCode();
        }

        public override string ToString()
        {
            return Fname + " " + Lname;
        }


        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
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
