using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2022_10_06_1._3._2
{
    //Definition der Klasse Auto
    class Auto
    {
        //Instanzvariablen
        public int Reifen;
        public double Motor;
        public string Türen;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration einer Objektvariable
            Auto Model1;

            //Instanzierung
            Model1 = new Auto();//oder Auto Model1 = new Auto();
        }
    }
}
