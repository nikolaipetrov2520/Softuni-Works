using System;
namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Snake snake = new Snake("Eho");
            Console.WriteLine(snake.Name);
        }
    }
}