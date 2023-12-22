using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System;
using System.Text.RegularExpressions;

namespace ovningSelection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övning 1: Skapa ett program som frågar användaren vilket land som vann fotbolls - VM för damer
            //år 2015.Om användaren svarar USA ska programmet skriva ut att svaret var rätt, annars ska
            //programmet skriva ut att svaret var fel.Det ska inte spela någon roll om användaren skriver
            //svaret med stora eller små bokstäver
            //Console.WriteLine("Vilket lag vann VM i fotboll för damer 2015?");
            //string svar = Console.ReadLine();
            //string storEllerLiten = svar.ToUpper();
            //if (storEllerLiten == "USA")
            //{
            //    Console.WriteLine("Du har rätt!");
            //}
            //else
            //{
            //    Console.WriteLine("Fel svar!");
            //}

            //Övning 2: Medelåldern i Göteborgs kommun är 39 år.Medellönen i Sverige är 36100 kr / månad.
            //Skapa ett program som frågar användaren efter hens ålder och månadslön.Programmet ska
            //sedan säga om användaren är lika gammal som, yngre eller äldre än medelpersonen i Göteborg.
            //Därefter ska programmet säga om användaren tjänar lika mycket som, mindre eller mer än
            //meddellönen i Sverige.

            //Console.WriteLine("Hur gammal är du?");
            //int inputAge = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hur mycket tjänar du?");
            //int inputSalary = int.Parse(Console.ReadLine());

            //if (inputAge == 39)
            //{
            //    Console.WriteLine("Du är meddelålders i Göteborg...");
            //}
            //if (inputAge < 39)
            //{
            //    Console.WriteLine("Du är under meddelåldern i Göteborg.");
            //}
            //if (inputAge > 39)
            //{
            //    Console.WriteLine("Du är över medelåldern i Göteborg.");
            //}
            //if (inputSalary == 36100)
            //{
            //    Console.WriteLine("Du har meddellönen i Sverige.");
            //}
            //if (inputSalary > 36100)
            //{
            //    Console.WriteLine("Du tjänar över medellönen i Sverige.");
            //}
            //if (inputSalary < 36100)
            //{
            //    Console.WriteLine("Du tjänar under medellönen i Sverige.");
            //}

            //Övning 3: Skriva ett program som frågar efter användarens namn och ålder för att sedan ange i
            //vilken grupp som användaren hamnar i flygbolagets speciella ordning.
            //1.Alla som heter Felicia och Felix eftersom de har namnsdag.
            //2.Alla som är äldre än 75 år.
            //3.Alla som är från 18 t.o.m 25 år
            //4.Övriga passagerare
            //Console.WriteLine("Vad heter du?");
            //string namn = Console.ReadLine();
            //Console.WriteLine("Hur gammal är du?");
            //int ålder = int.Parse(Console.ReadLine());
            //if (namn == "Felicia" || namn == "Felix")
            //{
            //    Console.WriteLine("Du har namnsdag idag.");
            //}
            //if (ålder > 74)
            //{
            //    Console.WriteLine("Du är över 75");
            //}
            //else
            //{
            //    Console.WriteLine("Övriga...");
            //}

            //Övning 4: Ett kafé utlyser en kampanj där personer äldre än 65 år samt personer mellan 10 och
            //18 erbjuds att köpa kaffe till ett extra billigt pris.Skriv ett program som innehåller endast en ifsats som
            //undersöker om användaren kan få köpa kaffe extra billigt.

            //Console.WriteLine("Hur gammal är du?");
            //int ålder = int.Parse(Console.ReadLine());
            //if (ålder > 64 || ålder > 10 && ålder < 18)
            //{
            //    Console.WriteLine("Du får extrapris");
            //}
            //else
            //{
            //    Console.WriteLine("Du får betala fullt pris!");
            //}
        }
    }
}
