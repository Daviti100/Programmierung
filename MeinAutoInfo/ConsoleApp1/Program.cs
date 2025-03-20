using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug meinFahrzeug = new Fahrzeug("VW", 2025, 0, "PKW");
            Console.WriteLine("Mein Fahrzeug Info:");
            Console.WriteLine();
            meinFahrzeug.FahrzeugInfo();
            Console.WriteLine();
            Auto meinAuto = new Auto("BMW", 2025, 1000, "PKW", 4);
            Console.WriteLine("Mein Auto Info:");
            Console.WriteLine() ;
            meinAuto.AutoInfo();
            Console.ReadLine();
        }
    }
    public class Fahrzeug
    {
        public string Marke { get; set; }
        public int Baujahr {  get; set; }
        public double Kilometerstand {  get; set; }
        public string Fahrzeugart {  get; set; }
        public  Fahrzeug(string marke, int baujahr, double kilometerstand,string fahrzeugart)
        {
            Marke = marke;
            Baujahr = baujahr;
            Kilometerstand = kilometerstand;
            Fahrzeugart = fahrzeugart;
        }
        public void FahrzeugInfo()
        {
            Console.WriteLine("Marke: " + Marke);
            Console.WriteLine("Baujahr: " + Baujahr);
            Console.WriteLine("Kilometerstand: " + Kilometerstand+"km");
            Console.WriteLine("Fahrzeugart: " + Fahrzeugart);
        }
    }
    public class Auto:Fahrzeug
    {
        public int AnzahlDerTueren {  get; set; }
        public Auto(string marke, int baujahr, double kilometerstand, string fahrzeugart, int anzahlDerTueren):base (marke, baujahr, kilometerstand, fahrzeugart) 
        {
            AnzahlDerTueren = anzahlDerTueren;
        }
        public void AutoInfo()
        {
            
            FahrzeugInfo();            
            Console.WriteLine("Anzahl Die Tueren: " + AnzahlDerTueren);
        }
    }
}
