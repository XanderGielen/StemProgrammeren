using System;
using System.Collections.Generic;

class SnakeGame
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(40, 20);

        int width = Console.WindowWidth;
        int height = Console.WindowHeight;

        // Initialize the snake
        List<int[]> snake = new List<int[]>();
        snake.Add(new int[] { width / 2, height / 2 });
        snake.Add(new int[] { width / 2, height / 2 + 1 });
        snake.Add(new int[] { width / 2, height / 2 + 2 });

        // Initialize the food
        int[] food = new int[] { new Random().Next(0, width), new Random().Next(0, height) };

        // Initialize the direction
        int[] direction = new int[] { 0, -1 };

        // Game loop
        while (true)
        {
            // Clear the console
            Console.Clear();

            // Draw the snake
            foreach (int[] segment in snake)
            {
                Console.SetCursorPosition(segment[0], segment[1]);
                Console.Write("O");
            }

            // Draw the food
            Console.SetCursorPosition(food[0], food[1]);
            Console.Write("*");

            // Move the snake
            int[] head = snake[0];
            int[] newHead = new int[] { head[0] + direction[0], head[1] + direction[1] };
            snake.Insert(0, newHead);
            snake.RemoveAt(snake.Count - 1);

            // Check for collision with the wall
            if (newHead[0] < 0 || newHead[0] >= width || newHead[1] < 0 || newHead[1] >= height)
            {
                Console.SetCursorPosition(0, height + 1);
                Console.WriteLine("Game over!");
                break;
            }

            // Check for collision with the food
            if (newHead[0] == food[0] && newHead[1] == food[1])
            {
                food = new int[] { new Random().Next(0, width), new Random().Next(0, height) };
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }

            // Check for collision with the snake
            for (int i = 1; i < snake.Count; i++)
            {
                if (newHead[0] == snake[i][0] && newHead[1] == snake[i][1])
                {
                    Console.SetCursorPosition(0, height + 1);
                    Console.WriteLine("Game over!");
                    break;
                }
            }

            // Read the user input
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.W)
                {
                    direction = new int[] { 0, -1 };
                }
                else if (key.Key == ConsoleKey.A)
                {
                    direction = new int[] { -1, 0 };
                }
                else if (key.Key == ConsoleKey.S)
                {
                    direction = new int[] { 0, 1 };
                }
                else if (key.Key == ConsoleKey.D)
                {
                    direction = new int[] { 1, 0 };
                }
            }

            // Wait for a short time
            System.Threading.Thread.Sleep(100);
        }

        Console.CursorVisible = true;
    }
}
