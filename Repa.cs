using System;
namespace Repa_bm
{
    public class Repa
    {
        static private Random random = new Random();
        private int kor;
        private double minosseg;
        private int tapErtek;
        private string fajta;

        public int Kor
        {
            get
            {
                return kor;
            }
            private set
            {
                if (value >= 0)
                {
                    kor = value;
                }
            }
        }

        public double Minoseg
        {
            get
            {
                return minosseg;
            }
            set
            {
                if(value>0 && value < 1)
                {
                    minosseg = value;
                }
                else if (value < 0)
                {
                    minosseg = 0;
                }
                else if (value > 1)
                {
                    minosseg = 1;
                }
            }
        }

        public double Tapertek
        {
            get
            {
                return tapErtek * minosseg;
            }
        }
        public Repa()
        {
            Kor = 0;
            tapErtek = random.Next(1, 7);
            Minoseg = 0.99;
            string[] repak = new string[] { "sárgarépa","fehérrépa","cukorrépa" };

            fajta = repak[random.Next(0, 3)];

        }
        public Repa(string fajta)
        {
            Kor = 0;
            tapErtek = random.Next(1, 7);
            Minoseg = 0.99;

            this.fajta = fajta;
        }
        public string Informacio()
        {
            return $"{fajta} ({Kor} éves) minőssége: {Minoseg*100}% tápértéke: {Tapertek} egység";
        }
        public bool Tick(double minoseg)
        {
            Kor += 1;
            Minoseg -= minoseg;

            return (Kor <=7 && Minoseg>=0);
        }
    }
}
