using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TanksGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();

        }
        Player player;
        List<Enemy> enemies;
        List<Bonus> bonuses;
        List<Wall> walls;
        List<Shell> shells;
        Bitmap bitmap;
        private void GameForm_Load(object sender, EventArgs e)
        {
            int[,] vs = new int[10, 10];
            GameStart(5, 30, 5, 10, 10);
        }

        public void GameStart(int speed, int health, int countEnemies, int damageEnemy, int damagePlayer)
        {
            bitmap = new Bitmap(pBGameField.Width - 5, pBGameField.Height - 5);
            player = new Player(health, 10, 10, 50, 50, speed, damagePlayer, Direction.TOP);
            player.CreateSubject(bitmap);
            pBGameField.Image = bitmap;
            timeRefresh.Enabled = true;
            Main();
        }
        public void Main()
        {
            while (true)
            {
                
            }
        }

        public void UpdateGameObjects()
        {
            
        }
        public void HandleInput(Timer timer, KeyEventArgs key)
        {
            if (key.KeyData == Keys.Up)
            {  
                if(player.Direction == Direction.RIGHT)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if(player.Direction == Direction.BOTTOM)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if(player.Direction == Direction.LEFT)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                player.Direction = Direction.TOP;
                player.Top--;
            }
            else if(key.KeyData == Keys.Right)
            {
                if (player.Direction == Direction.TOP)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (player.Direction == Direction.BOTTOM)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (player.Direction == Direction.LEFT)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                player.Direction = Direction.RIGHT;
                player.Left++;
            }
            else if (key.KeyData == Keys.Down)
            {
                if (player.Direction == Direction.TOP)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (player.Direction == Direction.RIGHT)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (player.Direction == Direction.LEFT)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                player.Direction = Direction.BOTTOM;
                player.Top++;
            }
            else if (key.KeyData == Keys.Left)
            {
                if (player.Direction == Direction.TOP)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (player.Direction == Direction.RIGHT)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (player.Direction == Direction.BOTTOM)
                {
                    player.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                player.Direction = Direction.LEFT;
                player.Left--;
            }
        }

        private void timeRefresh_Tick(object sender, EventArgs e)
        {
            if(keybo)
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            HandleInput(timeRefresh, e);
        }
    }
}
