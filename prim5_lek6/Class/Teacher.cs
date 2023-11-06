using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim5_lek6.Class
{
    
    public class Teacher : IComparable
    { 
        string degree = "";
        int experience = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Teacher()
        {
            FirstName = "";
            LastName = "";
            Experience = 0;
        }
        public Teacher(string firstName, string lastName, int experience)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;

        }
        public string Degree
        {
            get { return degree; }
            set
            {
                if (String.Equals(value, "PhD") 
                    || String.Equals(value, "DSc")
                    || String.Equals(value, "Null"))
                { degree = value; }
                else degree = "Null";
            }
        }
        public int Experience
        {
            get { return experience; }
            set
            {
                if (value >= 0)
                    experience = value;
                else throw new ArgumentException("Experience<=0");
            }
        }
        public int CompareTo(object obj)
        {
            Teacher p = obj as Teacher;
            //реалізуємо інтерфейс для порівняння стажу
            return Experience.CompareTo(p.Experience);
        }
    }
}
