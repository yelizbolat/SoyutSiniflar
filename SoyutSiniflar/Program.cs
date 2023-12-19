using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyutSiniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            kitap.Oku();

            Dergi dergi = new Dergi();
            dergi.Oku();

            Ansiklopedi ansiklopedi = new Ansiklopedi();
            ansiklopedi.Oku();
        }
    }
    public abstract class Kutuphane
    {
        public string Ad { get; set; }
        public double BasimYili { get; set; }
        public int Sayfa { get; set; }
        public string Yazari { get; set; }

        public abstract void Oku();
    }
    public class Kitap : Kutuphane
    {
        public string Turu { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Kitap okuma işlemi tamam");
        }
    }
    public class Dergi : Kutuphane
    {
        public double BasimYeri { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Dergi okuma işlemi tamam");
        }
    }
    public class Ansiklopedi : Kutuphane
    {
        public string ciltNo { get; set; }
        public override void Oku()
        {
            Console.WriteLine("Ansiklopedi okuma işlemi tamam");
        }
    }
}
