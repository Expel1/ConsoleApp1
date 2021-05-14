using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, double> latky = new Dictionary<string, double>();
            latky.Add("voda", 977);
            latky.Add("zlato", 19320);
            latky.Add("olovo", 13530);
            latky.Add("asfalt", 1300);
            latky.Add("papír", 800);
            latky.Add("teflon", 2200);

            Teleso teleso1 = new Teleso("voda",50 , 16);
            Teleso teleso2 = new Teleso("zlato", 4 , latky);
            Teleso teleso3 = new Teleso(9 , "olovo", latky);
            Teleso teleso4 = new Teleso("asfalt", 7 , latky);
            Teleso teleso5 = new Teleso(18 , "papír", latky);
            Teleso teleso6 = new Teleso("teflon", 29 , latky);


            Console.Write( teleso1.Hustota);
            Console.Write( teleso1.Hmotnost);
            Console.WriteLine( teleso1.Objem);
            Console.WriteLine(teleso2.Objem);
            Console.WriteLine( teleso3.Hmotnost);
            Console.WriteLine(teleso4.Objem);
            Console.WriteLine( teleso5.Hmotnost);
            Console.WriteLine(teleso6.Objem);
            Console.Read();
            }
        }
    }
class Teleso
{

    public string Latka { get; set; }
    public double Hmotnost { get; set; }
    public double Objem { get; set; }
    public double Hustota { get; set; }

    public Teleso(string latka, double hmotnost, double objem)
    {
        Latka = latka;
        Hmotnost = hmotnost;
        Objem = objem;
        Hustota = Hmotnost / Objem;

    }
    public Teleso(string latka, double hmotnost, Dictionary<string, double> latky)
    {
        Latka = latka;
        Hmotnost = hmotnost;
        foreach (var item in latky)
        {
            if (latka == item.Key)
            {
                Hustota = item.Value;
            }
        }
        Objem = Hmotnost * Hustota;
    }
    public Teleso(double objem, string latka, Dictionary<string, double> latky)
    {
        Latka = latka;
        Objem = objem;
        foreach (var item in latky)
        {
            if (latka == item.Key)
            {
                Hustota = item.Value;
            }
        }
        Hmotnost = Objem * Hustota;

    }
}


