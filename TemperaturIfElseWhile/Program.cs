using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void CheckTemp()
        {
            int temp = GetInt("Write temperature: ");

            if (temp < 0)
            {
                Console.WriteLine("Det er minus grader!\n");
            }
            else if (temp > 0)
            {
                Console.WriteLine("Det er pluss grader!\n");
            }
            else
            {
                Console.WriteLine("Det er null grader!\n");
            }

            CheckTemp();
        }

        static int GetInt(string text = "Write a number: ")
        {
            int num;
            bool ok;
            do
            {
                Console.Write(text);
                ok = int.TryParse(Console.ReadLine(), out num);
                if (!ok)
                {
                    Console.WriteLine("Error: write only a number");
                }
            } while (!ok);

            return num;
        }

        static void Main(string[] args)
        {
            CheckTemp();

            //Clone dette prosjektet. [x]

            //oppgave1 - her brukes if/else int.Parse()/TryParse()
            //lag et program som leser inn et tall, en temperatur, fra en bruker
            //programmet ditt skal så skrive ut om det er pluss, minus eller null 

            //For å parse fra string til en int må det parses. (Når vi leser fra Console. Console.ReadLine()). Om man bruker int.Parse(), vi programmet krasje om det ikke er en numerisk verdi inntastet
            //Bruk derfor metoden TryParse() https://www.tutorialspoint.com/chash-int-tryparse-method

            //Oppgave 2
            //Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet.

            //Oppgave 3 - bruk av en loop - while
            //Om brukeren taster en ugyldig verdi, skal brukeren få en beskjed om at feil verdi er inntastet, som i oppgave 2. Brukeren skal så få mulighet til å 
            //taste inn en verdi, helt til at en gyldig verdi er inntastet. while er et godt valg av loop her. https://www.programiz.com/csharp-programming/do-while-loop

            //oppgave 4
            //Leg det hele i Git. Public repo. Send linken i oppgave i teams.

            Console.ReadLine();
        }
    }
}
