using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class skills
    {
        public List<string> skillPersonal { get; set; }
        public List<string > skillTechnical { get; set; } 

        public skills() { 
        skillPersonal = new List<string>();
            skillTechnical = new List<string>();
        }

        public void DisplayPersonal() {
            for (int i = 0; i < skillPersonal.Count; i++) { 
             Console.WriteLine(skillPersonal[i]);
            }
        
        }

        public void DisplayTechnical() {
            for (int i = 0; i < skillTechnical.Count; i++) {
                Console.WriteLine(skillTechnical[i]);
            }
        }

        public void AddPersonal(string skill) {
            skillPersonal.Add(skill);
          }

        public void AddTechnical(string skill)
        {
            skillTechnical.Add(skill);
        }

        public void RemovePersonal(string skill) {  
            skillPersonal.Remove(skill); 
        }

        public void RemoveTechnical(string skills) { 
        skillTechnical.Remove(skills);
        }



    }
}
