using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webaddressbooktests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {

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

            if (Object.ReferenceEquals(Lname, other.Lname))
            {
                return Fname.CompareTo(other.Fname);
            }
            return Lname.CompareTo(other.Lname);

            // return Fname.CompareTo(other.Fname);
            
        }
        public override int GetHashCode()
        {

            return Lname.GetHashCode() +
                Fname.GetHashCode();
        }

        public override string ToString()
        {
            return Lname + " " + Fname;
        }


        public string id { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Nick { get; set; }

        public string Comp { get; set; }

        public string Hom { get; set; }
        public string Place { get; set; }
    }
}
