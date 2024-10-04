namespace Events
{
    internal class Program
    {
        static void Fire(object sender, EventArgs e)
        {
            Console.WriteLine("Пожар");
        }

        static void Main(string[] args)
        {
            Switcher sw = new Switcher();
            Lamp lamp = new Lamp();
            TvSet tv = new TvSet();

            // подписка на событие
            //sw.ElectricityOn += new Electricity( lamp.LightOn ); // old version , c# 4.0
            sw.ElectricityOn += lamp.LightOn;
            sw.ElectricityOn += tv.TvOn;

            // отписка от события
            //sw.ElectricityOn -= lamp.LightOn;

            sw.ElectricityOn += Program.Fire;
            sw.ElectricityOn += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("Всё сгорело");
            };

            // lambda
            sw.ElectricityOn += (s,e) => Console.WriteLine("Пожарные приехали");


            sw.SwitchOn();

            //Func<double, double> Cube = x => x * x * x;
            double Cube(double x) => x * x * x;

            Console.WriteLine(Cube(3.5));


        }
    }
}
