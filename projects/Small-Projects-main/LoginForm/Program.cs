using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class SnakeGame : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public SnakeGame()
        {
            InitializeComponent();
            new Setings();

            gameTimer.Interval = 1000 / Setings.Speed;
            gameTimer.Tick += updateScreen;
            gameTimer.Start();

            StartGame();
        }
        private void updateScreen(object sender, EventArgs e)
        {
            if (Setings.GameOver == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPress(Keys.Right) && Setings.direction != Directions.Left)
                {
                    Setings.direction = Directions.Right;
                }
                else if (Input.KeyPress(Keys.Left) && Setings.direction != Directions.Right)
                {
                    Setings.direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && Setings.direction != Directions.Down)
                {
                    Setings.direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && Setings.direction != Directions.Up)
                {
                    Setings.direction = Directions.Down;
                }

                MovePlayer();

            }

            pbCanvas.Invalidate();

        }

        private void Updategraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (Setings.GameOver == false)
            {
                Brush snakeColor;
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColor = Brushes.Black;
                    }
                    else
                    {
                        snakeColor = Brushes.Green;
                    }

                    canvas.FillEllipse(snakeColor, new Rectangle(Snake[i].X * Setings.Width, Snake[i].Y * Setings.Height,
                                                                  Setings.Width, Setings.Height));

                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X * Setings.Width, food.Y * Setings.Height,
                                                                   Setings.Width, Setings.Height));
                }
            }
            else
            {
                string gameover = "Game Over \n" + "Final score is " + Setings.Score + "\n Pres enter to restart";
                label3.Text = gameover;
                label1.Visible = true;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);

        }
        private void StartGame()
        {
            label3.Visible = false;
            new Setings();
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 10 };
            Snake.Add(head);
            label2.Text = Setings.Points.ToString();

            GenerateFood();
        }
        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Setings.direction)
                    {
                        case Directions.Right:
                            Snake[1].X++;
                            break;
                        case Directions.Left:
                            Snake[1].X--;
                            break;
                        case Directions.Up:
                            Snake[1].Y--;
                            break;
                        case Directions.Down:
                            Snake[1].Y++;
                            break;
                    }
                    int maxXpos = pbCanvas.Size.Width / Setings.Width;
                    int maxYpos = pbCanvas.Size.Width / Setings.Height;

                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X > maxXpos || Snake[i].Y > maxYpos)
                    {
                        Die();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        EatFood();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        private void GenerateFood()
        {
            int maxXpos = pbCanvas.Size.Width / Setings.Width;
            int maxYpos = pbCanvas.Size.Height / Setings.Height;

            Random rnd = new Random();
            food = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
        }
        private void EatFood()
        {
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            Setings.Score += Setings.Points;
            label2.Text = Setings.Score.ToString();

            GenerateFood();
        }
        private void Die()
        {
            Setings.GameOver = true;
        }

    }
}