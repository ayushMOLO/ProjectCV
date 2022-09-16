using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class Program
    {
        public static void intro()
        {
            Console.WriteLine("Introducing myself");
            Console.Write("My name is Vishishta P.Nursimooloo. I am in my second year of unversity at the University of Mauritius ");
            Console.WriteLine("This is my CV");
            Console.WriteLine();
        }

        public static void Menu() {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Experience");
            Console.WriteLine("2.Education");
            Console.WriteLine("3.Skills");
         }

        public static void ResetScreen() {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static int Enter(string name) {
            Console.WriteLine("Enter "+ name);
            return int.Parse(Console.ReadLine());       
        }



        static void Main(string[] args)
        {

            while (true)
            {
                intro();
                Menu();
               
               int choice=Enter("Choice");

                if (choice == 1)
                {

                    Experience[] xp = new Experience[2];

                    xp[0] = new Experience("Ceridian");
                    xp[1] = new Experience("PWC");
                    int i = 0;
                    Console.Clear();
                    for (; i < xp.Length; i++)
                    {
                        Console.Write(i + 1 + " ");
                        xp[i].DislayName();
                    }
                    i++;
                    Console.WriteLine(i  + " GO BACK");

                    int secondChoice=Enter("choice");

                    if (secondChoice < i)
                    {
                        xp[secondChoice - 1].DisplayAll();
                    }

                    else if (secondChoice == i)
                    { 
                        Console.Clear();
                       
                    }
                   
                }//end experience

                if (choice == 2) {
                    Education[] educations = new Education[2];
                    
                    int i = 0;
                    Console.Clear();
                    for (; i < educations.Length; i++)
                    {
                        educations[i] = new Education();
                        Console.Write(i + 1 + " ");
                        educations[i].DislayName();
                    }
                    i++;
                    Console.WriteLine(i + " GO BACK");

                    int secondChoice=Enter("choice");

                    if (secondChoice < i)
                    {
                        educations[secondChoice - 1].DisplayYear();
                       int level= Enter("Level");
                        educations[secondChoice - 1].DisplayModule(level);
                        
                    }

                    else if (secondChoice==i)
                    { Console.Clear();
                        
                    }
                    
                }//End education

                if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("1.Personal");
                    Console.WriteLine("2.technical");
                    Console.WriteLine("3.GO BACK");
                    skills skill;
                    int secondChoice = Enter("choice");

                    if (secondChoice == 1)
                    {
                        Console.Clear();
                        skill = new skills();
                        skill.AddPersonal("eloquent");
                        skill.AddPersonal("fast learner");
                        skill.DisplayPersonal();

                    }

                    if (secondChoice == 2)
                    {
                        Console.Clear();
                        skill = new skills();
                        skill.AddTechnical("C++");
                        skill.AddTechnical("Java");
                        skill.AddTechnical("C");
                        skill.DisplayTechnical();

                    }

                    else if (secondChoice==3){ ResetScreen(); }


                }//end skill

                ResetScreen(); 
            }

            



        }
    }
}
