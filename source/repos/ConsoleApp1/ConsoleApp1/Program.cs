using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kordinate
    {
        public double Sirina { get; set; }
        public double Duzina { get; set; }

        public Kordinate(double sirina, double duzina)
        {
            Sirina = sirina;
            Duzina = duzina;
        }
    }
    public static class KordinateIzduzenje
    {
        public static double UdaljenostDo(this Kordinate osnovne, Kordinate ciljne)
        {
            return UdaljenostDo(osnovne, ciljne, UnitOfLenght.Kilometri);
        }
        public static double UdaljenostDo(this Kordinate osnove, Kordinate ciljen, UnitOfLenght unit)
        {
            var baseRad = Math.PI * ciljen.Sirina / 180;
            var targetRad = Math.PI * ciljen.Duzina / 180;
            var theta = osnove.Duzina - ciljen.Duzina;
            var thetaRad = Math.PI * theta / 180;

            double dist =
                Math.Sin(baseRad) * Math.Sin(targetRad) + Math.Cos(baseRad) *
                Math.Cos(targetRad) * Math.Cos(thetaRad);
            dist = Math.Acos(dist);

            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return unit.ConvertFromMiles(dist);
        }
    }
    public class UnitOfLenght
    {
        public static UnitOfLenght Kilometri = new UnitOfLenght(1.6);
        public static UnitOfLenght Milje = new UnitOfLenght(0.87);
        public static UnitOfLenght Metri = new UnitOfLenght(1);

        private readonly double _fromMilesFactor;

        private UnitOfLenght(double fromMilesFactor)
        {
            _fromMilesFactor = fromMilesFactor;
        }
        public double ConvertFromMiles(double input)
        {
            return input * _fromMilesFactor;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
