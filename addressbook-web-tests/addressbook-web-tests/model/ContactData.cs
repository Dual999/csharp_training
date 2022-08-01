using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;





namespace webaddressbooktests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string allPhones;

        public ContactData(string fname , string lname)
        {
            Fname = fname;
            Lname = lname;
        }

        public ContactData()
        {
        }

        public ContactData(string fname)
        {  
            Fname = fname;
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
            int result = Lname.CompareTo(other.Lname);
            if (result != 0) {

                return result;
            }
            else
            {

                return Fname.CompareTo(other.Fname);
            }
            //if (Object.ReferenceEquals(Lname, other.Lname))
            //{
            //    return Fname.CompareTo(other.Fname);
            //}
            //return Lname.CompareTo(other.Lname);

            
        }
        public override int GetHashCode()
        {
            return (Fname + " " + Lname).GetHashCode();
            //return Lname.GetHashCode() +
            //    Fname.GetHashCode();
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

        public string AllPhones 
        
        {
            get
            {
                if (allPhones != null )
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(HomePhone) + CleanUp(MobilePhone) + CleanUp(WorkPhone)).Trim();
                }
            }
            
            set
            {
                allPhones = value;
            }      
        
        
        }

        private string CleanUp(string phone)
        {
            if (phone== null || phone == "")
            {
                return "";
            }

            return Regex.Replace(phone, "[ -()]", "") + "\r\n";
        }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string WorkPhone { get; set; }

        public string Address { get; set; }
        public string Place { get; set; }
    }
}
