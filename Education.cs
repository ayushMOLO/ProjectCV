using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class Education
    {
        string Name;
        year[] years;

        public Education()
        {
            Name = "University";
            years = new year[2];
            years[0] = new year();
            years[1] = new year();

        }

        public void Displaysub()
        {
            Console.WriteLine(Name);
            //DisplayYear();
        }

        public void DisplayYear()
        {
            for (int i = 0; i < years.Length; i++)
            {
                int j = i + 1;
                Console.WriteLine("Year "+j);

            }
        }

        public void DisplayModule(int year)
        {
            for(int i = 0; i < years[year-1].module.Length; i++)
            {
                Console.WriteLine("Module Name "+ years[year-1].module[i]);
            }

        } 
    }
}
