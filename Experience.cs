using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class Experience
    {
        //private string CompanyName;
        //private DateTime dateFrom;
        //private DateTime DateTo;
        //private string Description;

        public string CompanyName { get; set; }
        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public string Description { get; set; }

        public Experience() { CompanyName = "Ceridian"; }
        public Experience(string companyName, DateTime dateFrom, DateTime dateTo, string description)
        {
            CompanyName = companyName;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Description = description;
        }

        public Experience(string companyName) {
            CompanyName = companyName;
        }

        public void Displaysub() {
            
            Console.WriteLine("Name of company " + CompanyName);

        }
        public void DisplayAll()
        {
            Console.WriteLine("Name of company "+CompanyName);
            Console.WriteLine("Date From " + DateFrom);
            Console.WriteLine("Date To " + DateTo);
            Console.WriteLine("Descrition "+Description);   

        }








    }
}
