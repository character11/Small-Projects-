using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public enum Directions
    {
        Left,
        Up,
        Right,
        Down,
    }
    class Setings
    {
        public static int Width { get; set; } //set the width as int class
        public static int Height { get; set; } //set the height as int class
        public static int Speed { get; set; } //set the speed as int class
        public static int Score { get; set; } //set the score as int class
        public static int Points { get; set; } //set the points as int class
        public static bool GameOver { get; set; } //set the GameOver as boolean class
        public static Directions direction { get; set; } //set direction as class

        public Setings()
        {
            //THIS IS THE DEFAULT SETING FUNCTION
            Width = 16;
            Height = 16;
            Speed = 20;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Directions.Down;

        }
    }
}
