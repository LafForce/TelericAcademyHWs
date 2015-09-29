<<<<<<< .mine
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class FallingRockss
{
 struct Position
    {
        public int X;
        public Position(int x)
        {
            this.X = x;
        }
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine(@"Problem:
Falling Rocks
*Implement the Falling Rocks game in the text console.
*A small dwarf stays at the bottom of the screen and can move left and 
right(by the arrows keys).	
*A number of rocks of different sizes and forms constantly fall down and 
you need to avoid a crash.	
*Rocks are the symbols `^, @, *, &, +, %, $, #, !, ., ;, -` distributed 
withappropriate density. The dwarf is `(O)`.
*Ensure a constant game speed by `Thread.Sleep(150)`.
*Implement collision detection and scoring system.

-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("who cares about that dwarf anyways :! ");

  
        //// List with snake elements
        //Queue<Position> dwarfPosition = new Queue<Position>();

        //// Random generator for rocks
        //Random rockType = new Random(^, @, *, &, +, %, $, #, !, ., ;, -);

        //// The game speed
        //double sleepTime = 150;

        //// Available move directions
        //Position[] moveDirections = new Position[]
        //{
        //    new Position(1), // Right
        //    new Position(-1), // Left
        //};

           
        //// Console settings
        //Console.CursorVisible = false;
        //Console.BufferHeight = Console.WindowHeight;

        //// First snake and screen initialize
        //Position rock = new Position(
        //    randomGenerator.Next(1, Console.WindowWidth - 1),
        //for (int i = 0; i <= 6; i++)
        //{
        //    snakeElements.Enqueue(new Position(i, 0));
        //}
        //foreach (var item in snakeElements)
        //{
        //    Console.SetCursorPosition(item.X, item.Y);
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.Write("*");
        //}
        //Position snakeHead = snakeElements.Last();
        //Console.SetCursorPosition(snakeHead.X, snakeHead.Y);
        //Console.ForegroundColor = ConsoleColor.Gray;
        //Console.Write("@");

        //while (true)
        //{
        //    // Read user key
        //    if (Console.KeyAvailable)
        //    {
        //        ConsoleKeyInfo pressedKey = Console.ReadKey();
        //        if (pressedKey.Key == ConsoleKey.RightArrow)
        //            if (currentDirection != 2) currentDirection = 0;
        //        if (pressedKey.Key == ConsoleKey.DownArrow)
        //            if (currentDirection != 3) currentDirection = 1;
        //        if (pressedKey.Key == ConsoleKey.LeftArrow)
        //            if (currentDirection != 0) currentDirection = 2;
        //        if (pressedKey.Key == ConsoleKey.UpArrow)
        //            if (currentDirection != 1) currentDirection = 3;
        //    }

        //    // Write snake food
        //    Console.SetCursorPosition(food.X);
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.Write("+");

        //    // Previous snake head
        //    Position prevSnakeHead = snakeElements.Last();

        //    // New snake head
        //    Position newSnakeHead = new Position(
        //        prevSnakeHead.X + moveDirections[currentDirection].X,
        //        prevSnakeHead.Y + moveDirections[currentDirection].Y);

        //    // Check constraints
        //    if (newSnakeHead.X >= Console.WindowWidth ||
        //        newSnakeHead.X < 0 ||
        //        newSnakeHead.Y >= Console.WindowHeight ||
        //        newSnakeHead.Y < 0 ||
        //        snakeElements.Contains(newSnakeHead))
        //    {
        //        // Game is over
        //        Console.SetCursorPosition(0, 0);
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.WriteLine("Game over!!! Your points: {0}", snakeElements.Count);
        //        return;
        //    }

        //    // Write new snake head
        //    Console.SetCursorPosition(prevSnakeHead.X, prevSnakeHead.Y);
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.Write("*");


        //    // Check if the snake is on food
        //    if (newSnakeHead.X == food.X && newSnakeHead.Y == food.Y)
        //    {
        //        // Feed the snake (the snake is eating)
        //        food = new Position(
        //            randomGenerator.Next(1, Console.WindowWidth - 1),
        //            randomGenerator.Next(1, Console.WindowHeight - 1));
        //        Console.SetCursorPosition(food.X, food.Y);
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.Write("+");
        //    }

        //    // Slow the motion
        //    Thread.Sleep((int)sleepTime);

        //    // Change the speed
        //    sleepTime -= 0.05;
        //}
    }
}
||||||| .r0
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class FallingRockss
{
 struct Position
    {
        public int X;
        public Position(int x)
        {
            this.X = x;
        }
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine(@"Problem:
Falling Rocks
*Implement the Falling Rocks game in the text console.
*A small dwarf stays at the bottom of the screen and can move left and 
right(by the arrows keys).	
*A number of rocks of different sizes and forms constantly fall down and 
you need to avoid a crash.	
*Rocks are the symbols `^, @, *, &, +, %, $, #, !, ., ;, -` distributed 
withappropriate density. The dwarf is `(O)`.
*Ensure a constant game speed by `Thread.Sleep(150)`.
*Implement collision detection and scoring system.

-------------------------------------------------------------------------------
Solution:

");
        Console.WriteLine("who cares about that dwarf anyways :! ");

  
        //// List with snake elements
        //Queue<Position> dwarfPosition = new Queue<Position>();

        //// Random generator for rocks
        //Random rockType = new Random(^, @, *, &, +, %, $, #, !, ., ;, -);

        //// The game speed
        //double sleepTime = 150;

        //// Available move directions
        //Position[] moveDirections = new Position[]
        //{
        //    new Position(1), // Right
        //    new Position(-1), // Left
        //};

           
        //// Console settings
        //Console.CursorVisible = false;
        //Console.BufferHeight = Console.WindowHeight;

        //// First snake and screen initialize
        //Position rock = new Position(
        //    randomGenerator.Next(1, Console.WindowWidth - 1),
        //for (int i = 0; i <= 6; i++)
        //{
        //    snakeElements.Enqueue(new Position(i, 0));
        //}
        //foreach (var item in snakeElements)
        //{
        //    Console.SetCursorPosition(item.X, item.Y);
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.Write("*");
        //}
        //Position snakeHead = snakeElements.Last();
        //Console.SetCursorPosition(snakeHead.X, snakeHead.Y);
        //Console.ForegroundColor = ConsoleColor.Gray;
        //Console.Write("@");

        //while (true)
        //{
        //    // Read user key
        //    if (Console.KeyAvailable)
        //    {
        //        ConsoleKeyInfo pressedKey = Console.ReadKey();
        //        if (pressedKey.Key == ConsoleKey.RightArrow)
        //            if (currentDirection != 2) currentDirection = 0;
        //        if (pressedKey.Key == ConsoleKey.DownArrow)
        //            if (currentDirection != 3) currentDirection = 1;
        //        if (pressedKey.Key == ConsoleKey.LeftArrow)
        //            if (currentDirection != 0) currentDirection = 2;
        //        if (pressedKey.Key == ConsoleKey.UpArrow)
        //            if (currentDirection != 1) currentDirection = 3;
        //    }

        //    // Write snake food
        //    Console.SetCursorPosition(food.X);
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.Write("+");

        //    // Previous snake head
        //    Position prevSnakeHead = snakeElements.Last();

        //    // New snake head
        //    Position newSnakeHead = new Position(
        //        prevSnakeHead.X + moveDirections[currentDirection].X,
        //        prevSnakeHead.Y + moveDirections[currentDirection].Y);

        //    // Check constraints
        //    if (newSnakeHead.X >= Console.WindowWidth ||
        //        newSnakeHead.X < 0 ||
        //        newSnakeHead.Y >= Console.WindowHeight ||
        //        newSnakeHead.Y < 0 ||
        //        snakeElements.Contains(newSnakeHead))
        //    {
        //        // Game is over
        //        Console.SetCursorPosition(0, 0);
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.WriteLine("Game over!!! Your points: {0}", snakeElements.Count);
        //        return;
        //    }

        //    // Write new snake head
        //    Console.SetCursorPosition(prevSnakeHead.X, prevSnakeHead.Y);
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.Write("*");


        //    // Check if the snake is on food
        //    if (newSnakeHead.X == food.X && newSnakeHead.Y == food.Y)
        //    {
        //        // Feed the snake (the snake is eating)
        //        food = new Position(
        //            randomGenerator.Next(1, Console.WindowWidth - 1),
        //            randomGenerator.Next(1, Console.WindowHeight - 1));
        //        Console.SetCursorPosition(food.X, food.Y);
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.Write("+");
        //    }

        //    // Slow the motion
        //    Thread.Sleep((int)sleepTime);

        //    // Change the speed
        //    sleepTime -= 0.05;
        //}
    }
}
>>>>>>> .r6
