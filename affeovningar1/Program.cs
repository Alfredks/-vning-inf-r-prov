using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affeovningar1
{
    class Program
    {
        static void Main(string[] args)
        { /* //övning1
            Console.WriteLine("mata in ett heltal: ");
            string inmatat = Console.ReadLine();
            int tal1 = int.Parse(inmatat);
            Console.WriteLine("mata in ett till heltal: ");
            inmatat = Console.ReadLine();
            int tal2 = int.Parse(inmatat);
            Console.WriteLine("summan av talen är: "+(tal1 + tal2).ToString());
            Console.ReadLine(); 

            //övning2
            Console.WriteLine("mata in ditt förnamn: ");
            string fornamn = Console.ReadLine();
            Console.WriteLine("mata in ditt efternamn: ");
            string efternamn = Console.ReadLine();
            Console.WriteLine("Hej " + fornamn + efternamn); 

            //övning3 
            Console.WriteLine("mata in grader i celsius: ");
            string inmatat = Console.ReadLine();
            int grader = int.Parse(inmatat);
            Console.WriteLine(grader * 1.8 + 32); 

            //övning4
            Console.Write("mata in grader i celsius: ");
            string inmatat = Console.ReadLine();
            int grader = int.Parse(inmatat);
            Console.WriteLine(grader * 1.8 + 32); 

            //övning5
            Console.WriteLine("mata in en radie: ");
            string inmatat = Console.ReadLine();
            double radie = double.Parse(inmatat);
            Console.WriteLine("area: " + (Math.PI * radie * radie));
            Console.WriteLine("omkrets: " + (Math.PI * radie * 2)); 

            //IF övningar nedan
            //övning1

            Console.WriteLine("tjocklek på ditt däck: ");
            string inmatat = Console.ReadLine();
            double däck = double.Parse(inmatat);
            if (däck < 1.6)
            {
                Console.WriteLine("olagligt däck");
            }
            else
            {
                Console.WriteLine("lagligt däck");
            } 

            //övning2
            Console.WriteLine("mata in ålder: ");
            string inmatat = Console.ReadLine();
            int ålder = int.Parse(inmatat);
            if (ålder < 12)
            {
                Console.WriteLine("vit");
            }
            else if (ålder < 19)
            {
                Console.WriteLine("grön");
            }
            else if (ålder < 25)
            {
                Console.WriteLine("röd");
            }
            else if (ålder < 99)
            {
                Console.WriteLine("blå");
            }
            else
            {
                Console.WriteLine("ogiltig ålder");
            } 

            //övning 3
            Console.WriteLine("mata in ett tal 1: ");
            string inmatat = Console.ReadLine();
            decimal x = decimal.Parse(inmatat);
            Console.WriteLine("mata in ett tal ");
            inmatat = Console.ReadLine();
            decimal y = decimal.Parse(inmatat);
            if (x > y)
            {
                Console.WriteLine("tal 1 var störst : " + x);
            }
            else if (y > x)
            {
                Console.WriteLine("tal 2 var störst : " + y);
            }
            else
            {
                Console.WriteLine("talen är lika stora!");
            } 

            //övning 4 
            Console.WriteLine("mata in ett tal: ");
            string inmatat = Console.ReadLine();
            int x = int.Parse(inmatat);
            if (x % 7 == 0)
            {
                Console.WriteLine("talet är jämnt delbart med 7");
            }
            else
            {
                Console.WriteLine("talet är inte delbart med 7. rest: " + x % 7);
            } 

            //Switch övningar nedan
            //övning1
            Console.WriteLine("mata in ett heltal");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("ett");
                    break;
                case 2:
                    Console.WriteLine("två");
                    break;
                case 3:
                    Console.WriteLine("tre");
                    break;
                case 4:
                    Console.WriteLine("fyra");
                    break;
                default:
                    Console.WriteLine("ogiltigt val");
                    break;
            }
            
            //övning 2
            Console.WriteLine("mata in ett heltal");
            string x = Console.ReadLine();
            switch (x)
            {
                case "N":
                    Console.WriteLine("north");
                    break;
                case "S":
                    Console.WriteLine("south");
                    break;
                case "E":
                    Console.WriteLine("east");
                    break;
                case "W":
                    Console.WriteLine("west");
                    break;
                default:
                    Console.WriteLine("I don't understand");
                    break;
            } 

            //FOR övningar nedan
            //övning1
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            } 

            //övning2
            for (int i = 20; i >= 0; i--)
            {
                Console.WriteLine(i);
            } 
            //övning3
            for (int i = 0; i <= 50; i = i + 2)
            {
                Console.WriteLine(i);
            } 

            //övning1
            Console.WriteLine("mata in start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("mata in stopp: ");
            int stopp = int.Parse(Console.ReadLine());
            Console.WriteLine("mata in steg: ");
            int steg = int.Parse(Console.ReadLine());

            for (int i = start; i <=stopp ; i = i + steg)
            {
                Console.WriteLine(i);
            } 

            //övning3
            Console.WriteLine("mata in ett heltal");
            int x = int.Parse(Console.ReadLine());
            int summa =0;
            for (int i = 1; i <= x; i++)
            {
                summa = summa + i;
                
            }
            Console.WriteLine(summa); 

            //övning4
            Console.WriteLine("mata in ett tal");
            int x = int.Parse(Console.ReadLine());
            int foundnumber = 0;
            for (int i = 1; i < x; i++)
            {
                if (i % 21 == 0)
                {
                    foundnumber++;
                    Console.WriteLine("talet: " + i + " är jämnt delbart med 3 och 7");
                }
                
            }
            if (foundnumber == 0)
            {
                Console.WriteLine(" hittade inga tal");
            }
            else
            {
                Console.WriteLine("hittade " + foundnumber + " tal jämnt delbart med 3 och 7");
            }
            
            //övning7
            Console.WriteLine("ange ett tal: ");
            int tal = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 3; i < tal; i++)
            {
                if (tal % (i - 1) == 0)
                {
                    count++;
                }           
               
            }
            if (count > 0)
            {
                Console.WriteLine("talet är inte ett primtal");
            }
            else
            {
                Console.WriteLine("talet är ett primtal");
            }
        
          //WHiLE övningar nedan

            //övning1
            int x = 1;
            while (x <=100)
            {
                Console.WriteLine(x);
                x++;
            } 

            //övning2
            string password = "Alfred123";
            Console.WriteLine("mata in lösenordet: ");
            string input = Console.ReadLine();
            int count = 1;
            while (input != password)
            {
                Console.WriteLine("wrong password!");
                count++;
                Console.WriteLine("try again: ");
                input = Console.ReadLine();

            }
            Console.WriteLine("correct password! number of tries: " + count); 

            //övning 3
            int x = 0;
            while (x<2)
            {
                Console.WriteLine("hej");
            } 

            //övning 4
            int talet = 67;
            Console.WriteLine("gissa talet!");
            int guess = int.Parse(Console.ReadLine());
            int count = 1;
            while (guess != talet)
            {
                if (guess > talet)
                {
                    Console.WriteLine("för högt");
                    Console.WriteLine("gissa igen!");
                    guess = int.Parse(Console.ReadLine());
                    count++;
                }
                else if (guess < talet)
                {
                    Console.WriteLine("för lågt!");
                    Console.WriteLine("gissa igen!");
                    guess = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            Console.WriteLine("rätt! talet var: " + guess + " antal gissningar: " + count); 

            //övning 5
            int oldNumber = 1;
            int currentNumber = 1;
            int nextNumber = 0;

            while (currentNumber < 1000000)
            {
                nextNumber = currentNumber + oldNumber;
                oldNumber = currentNumber;
                currentNumber = nextNumber;
                Console.WriteLine(currentNumber);
                
            } 

            //övning 6
            Console.WriteLine("saldo: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("ränta: ");
            double ranta = double.Parse(Console.ReadLine());
            Console.WriteLine("mål: ");
            int mal = int.Parse(Console.ReadLine());
            int years = 0;

            while (saldo < mal)
            {
                saldo = saldo * ((ranta * 0.01) + 1);
                years++;
            }
            Console.WriteLine("det tar " + years + " år innan du når saldot " + saldo); 

            //NÄSTLADE LOOPAR övningar nedan
            //övning 1
            for (int i = 0; i < 10; i++)
            {
                
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            } 

            //Array övningar nedan
            //övning 1
            string[] namn = new string [10];
                Console.WriteLine("mata in ett namn");

                for (int i = 0; i < namn.Length; i++)
                {
                    namn[i] = Console.ReadLine();
                }
                for (int i = 0; i < namn.Length; i++)
                {
                    Console.WriteLine(namn[i]);
                } 
            int[] talen = new int[11];
            Console.WriteLine("mata in ett tal och tryck på enter 10 gånger");
            for (int i = 0; i < 10; i++)
            {
                talen[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 9; i >=0; i--)
            {
                Console.WriteLine(talen[i]);
            } 

            //SLUMP övningar nedan
            //övning 1 

            Random slump = new Random();
            int[] tal = new int [10];
            int summa = 0;
            for (int i = 0; i < 10; i++)
            {
                tal[i] = slump.Next(21);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tal[i]);
                summa = summa + tal[i];
            }
            Console.WriteLine("medel värdet = " + summa / 10); */
        }
    }
}
