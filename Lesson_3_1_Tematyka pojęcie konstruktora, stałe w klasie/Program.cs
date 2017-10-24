﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class car {
      private  double pojemonoscSilnika;
      private  string marka;
      private static int iloscKol;
      private const int iloscDrzwi = 4;
      static void pule()
        {
            iloscKol = 4;
        }
        private car() {}
      private car(double pojemonoscSilnika, string marka)
        {
            this.pojemonoscSilnika = pojemonoscSilnika;
            this.marka = marka;
            iloscKol = 3;
            print();
        }



        public static car create(double po, string ma)
        {
            car temp = new car(po, ma);
            temp.print();
            car.pule();
            temp.print();
            return temp;
        }

        void print() {
            Console.WriteLine(car.iloscDrzwi + " iloscKol " + car.iloscKol);
        }
        ~car() {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           car naw = car.create(1.9,"VW");
           Console.ReadKey();
        }
    }
}
