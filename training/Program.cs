using System;

namespace training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EngineFirst engine = new EngineFirst(11);
            engine.Start();
        }
    }

    abstract class Engine
    {
        protected int ExternalTemperature;
        protected double Inertia;
        protected double OverheatingTemperature;
        protected double C;

        public abstract void Start();
    }

    class EngineFirst : Engine
    {
        public int[] M { get; set; }
        public int[] V { get; set; }
        public double Hm { get; set; }
        public double Hv { get; set; }

        public CoolingEngine Cooling { get; private set; }

        public EngineFirst(int Temper)
        {  
            ExternalTemperature = Temper;
            Inertia = 10;
            M = new int[] { 20, 75, 100, 105, 75, 0 };
            V = new int[] { 0, 75, 150, 200, 250, 300 };
            OverheatingTemperature = 110;
            Hm = 0.01;
            Hv = 0.0001;
            Cooling = new CoolingEngine();
            Cooling.C = 1.1;
        }

        public override void Start()
        {
            Console.WriteLine(Cooling.C);
            Console.WriteLine("Hачало работы двигателя\n");
        }
    }

    class CoolingEngine : Engine
    {
        public double C {  get; private set; }

        

        public EngineFirst Engine;

        public override void Start()
        {
            Console.WriteLine(C);
            Console.WriteLine("Hачало работы двигателя\n");
        }
    }
}
