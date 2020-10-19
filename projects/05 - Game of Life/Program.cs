using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            World w = new World(8);
            while (true){
                Console.Clear();
                w.Output();
                Console.Write("Press ENTER to update.('q' to quit)");
                string key = Console.ReadLine();
                if (key == "q"){
                    break;
                }
                w.Update();
            }
        }
    }
}
