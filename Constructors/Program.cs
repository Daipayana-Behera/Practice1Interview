using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Patient p = new Patient("Khushi",23,"Cold");
           Console.ReadLine();
        }
    }
    public class Patient
    {
        public string Name;
        public int Age;
        public string Disease;

        public Patient(string n, int a, string d)
        {
            Name = n;
            Age = a;
            Disease = d;
            
            //constructor does't have any return type.
            //For printing data we use this 
            Console.Write(Name);
            Console.Write(',');
            Console.Write(Age);
            Console.Write(',');
            Console.Write(Disease);
        }
    }
}
