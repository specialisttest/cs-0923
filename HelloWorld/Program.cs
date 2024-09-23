namespace HelloWorld
{
    /// <summary>
    /// Main program class
    /// </summary>
    public class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }
        
        public string AppName { get; set; }
        
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">Command line parameters</param>
        static void Main(string[] args)
        {

            string preferedUserName; // camel notaion
            int counter, привет;

            SayHello();


            Console.WriteLine("Hello, World!");  // строчный комментарий
            Console.WriteLine("Hello, World!");  // строчный комментарий
            /*
             Блочный комментарий
             // строчный комментарий
            
              
            */

        }
    }
}
