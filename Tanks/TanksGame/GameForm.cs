using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Schema;

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
        List<Shell> shells = new List<Shell>();
        Bitmap bitmap;
        GameMap gameMap;
        public int BonusesCount;
        public int enemiesCount;
        public int mapWidth;
        public int mapHeight;
        public int speed;
        public int oldWidth;
        public int oldHeight;
        public int pbOldwidth;
        public int pbOldHeight;
        public int score=0;
        public delegate void Transfer(object sender, ReportEventArgs reportEventArgs);
        public event Transfer OnTransferInfo;

        private void GameForm_Load(object sender, EventArgs e)
        {
            btnGameStart.Enabled = false;
        }
        public void GameOver(bool winOrnot)
        {

            btnGameStart.Enabled = false;
            if (winOrnot)
            {
                label6.BackColor = System.Drawing.Color.Red;
                label6.Text = "YOU WIN";
            }
            else
            {
                label6.BackColor = System.Drawing.Color.Red;
                label6.Text = "K.I.A.";
            }
            tbBonus.Visible = true;
            tbEnemy.Visible = true;
            tbMapHeight.Visible = true;
            tbMapWidth.Visible = true;
            tbSpeed.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            btnGameStart.Visible = true;
            btnParameters.Visible = true;
            this.Height = oldHeight;
            this.Width = oldWidth;
            label6.Visible = true;
            timeRefresh.Enabled = false;
            pBGameField.Width = this.Width;
            pBGameField.Height = this.Height - 130;
            bitmap = new Bitmap(pBGameField.Width - 5, pBGameField.Height - 5);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(System.Drawing.Brushes.Red, 0, 0, pBGameField.Width, pBGameField.Height);
            labelcountScore.Text = "0";
        }

        public void GameStart(int speed, int health, int countEnemies, int damageEnemy, int damagePlayer,int countBonuses)
        {
            List<Shell> shells = new List<Shell>(5);
            oldWidth = this.Width;
            oldHeight = this.Height;
            this.Height = 100 * mapHeight;
            this.Width = 100 * mapWidth;
            pBGameField.Width = this.Width;
            pBGameField.Height = this.Height;
            shells.Clear();
            bitmap = new Bitmap(pBGameField.Width - 5, pBGameField.Height - 5);

            gameMap = new GameMap(0, 0, bitmap.Width, bitmap.Height);
            gameMap.CreateSubject(bitmap);

            player = new Player(health, 10, 10, 50, 50, speed, damagePlayer, Direction.TOP);
            player.CreateSubject(bitmap);

            enemies = new List<Enemy>(countEnemies);
            for(int i = 0; i < countEnemies; i++)
            {
                Enemy enemy = new Enemy(health, 67 * i, pBGameField.Width - 40, 35, 35, speed, damageEnemy, Direction.TOP);
                enemies.Add(enemy);
                enemy.CreateSubject(bitmap);
            }

            Random random = new Random();
            walls = new List<Wall>(10);
            for (int i = 0; i < 15; i++)
            {
                Wall wall = new Wall(random.Next(10, pBGameField.Height - 5) - 50, random.Next(100, pBGameField.Width - 100), 25, 50, 10);
                wall.image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                walls.Add(wall);
                wall.CreateSubject(bitmap);
            }
            BonusesCount = countBonuses;
            bonuses = new List<Bonus>(countBonuses);
            for (int i = 0; i < countBonuses; i++)
            {
                Bonus bonus = new Bonus(random.Next(10, pBGameField.Height - 5), random.Next(100, pBGameField.Width - 100), 10, 10);
                bonuses.Add(bonus);
                bonus.CreateSubject(bitmap);
            }

            score = 0;
            pBGameField.Image = bitmap;
            timeRefresh.Enabled = true;
        }
        

        public void UpdateGameObjects()
        {
            
            HandleInput();
            UpdateEnemies();
            UpdateWalls();
            RandomShooting();
            ShellBallistics();
            CheckCollisions();
            if (player.Health <= 0)
            {
                GameOver(false);
            }
            if (bonuses.Count < BonusesCount)
            {
                Random random = new Random();
                Bonus bonus = new Bonus(random.Next(10, 340), random.Next(100, 600), 10, 10);
                bonuses.Add(bonus);
            }
            if (enemies.Count == 0)
            {
                GameOver(true);
            }
        }
        public void UpdateWalls()
        {
            for(int i = 0; i < walls.Count; i++)
            {
                if (walls[i].Health <= 0)
                {
                    walls.RemoveAt(i);
                }
            }
        }
        public void UpdateEnemies()
        {
            Random random = new Random();
            for (int i = 0; i < enemies.Count; i++)
            {

                if (enemies[i].Direction == Direction.BOTTOM)
                {
                    if (enemies[i].oldDirection==Direction.LEFT)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.TOP)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.RIGHT)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    enemies[i].oldDirection = enemies[i].Direction;
                    enemies[i].Top+=enemies[i].Speed;
                }
                else if (enemies[i].Direction == Direction.LEFT)
                {
                    if (enemies[i].oldDirection == Direction.BOTTOM)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.TOP)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.RIGHT)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    }
                    enemies[i].oldDirection = enemies[i].Direction;
                    enemies[i].Left-= enemies[i].Speed; 
                }
                else if (enemies[i].Direction == Direction.RIGHT)
                {
                    if (enemies[i].oldDirection == Direction.BOTTOM)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.TOP)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.LEFT)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    }
                    enemies[i].oldDirection = enemies[i].Direction;
                    enemies[i].Left+= enemies[i].Speed; 
                }
                else if (enemies[i].Direction == Direction.TOP)
                {
                    if (enemies[i].oldDirection == Direction.BOTTOM)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.LEFT)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    else if (enemies[i].oldDirection == Direction.RIGHT)
                    {
                        enemies[i].image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    }
                    enemies[i].oldDirection = enemies[i].Direction;
                    enemies[i].Top-= enemies[i].Speed; 
                }
                if (enemies[i].counter < 1500)
                {
                    enemies[i].counter += timeRefresh.Interval;
                }
                else if (enemies[i].counter >= 1500)
                {
                    enemies[i].Direction = AutoInput(random);
                    enemies[i].counter = 0;
                }
                if (enemies[i].Health <= 0)
                {
                    enemies.RemoveAt(i);
                }
            }
        }
        public void RandomShooting()
        {
            for(int i = 0; i < enemies.Count; i++)
            {
                enemies[i].timeToShoot += timeRefresh.Interval;
                if (enemies[i].timeToShoot >= 1500)
                {
                    enemies[i].timeToShoot = 0;
                    Shell shell = new Shell(enemies[i].Top + (enemies[i].Height / 2),
                                            enemies[i].Left + (enemies[i].Width / 2),
                                            10, 10, 1, enemies[i].Damage, false, enemies[i].Direction);
                    shells.Add(shell);
                }
            }
        }
        public void ShellBallistics()
        {
            for(int i = 0; i < shells.Count; i++)
            {
                if (shells[i].Direction == Direction.BOTTOM)
                {
                    shells[i].Top += 15;
                }
                else if (shells[i].Direction == Direction.LEFT)
                {
                    shells[i].Left -= 15;
                }
                else if (shells[i].Direction == Direction.RIGHT)
                {
                    shells[i].Left += 15;
                }
                else if (shells[i].Direction == Direction.TOP)
                {
                    shells[i].Top -= 15;
                }
                
                shells[i].lifeTime -= timeRefresh.Interval;
                if (shells[i].lifeTime <= 0)
                {
                    shells.RemoveAt(i);
                }
            }
        }
        public Direction AutoInput(Random random)
        {
            Direction direction;
            direction = (Direction)random.Next(4);
            return direction;
            //var v = Enum.GetValues(typeof(T));
            //return (T)v.GetValue(new Random().Next(v.Length));

        }
        public void HandleInput()
        {
            if (Keyboard.IsKeyDown(Key.Up))
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
                player.Top-= player.Speed; 
            }
            else if(Keyboard.IsKeyDown(Key.Right))
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
                player.Left+= player.Speed;
            }
            else if (Keyboard.IsKeyDown(Key.Down))
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
                player.Top+=player.Speed;
            }
            else if (Keyboard.IsKeyDown(Key.Left))
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
                player.Left-= player.Speed;
            }
            if (player.timeToShoot > 0)
            {
                player.timeToShoot -= timeRefresh.Interval;
            }
            if (Keyboard.IsKeyDown(Key.Space))
            {
                if (player.timeToShoot <= 0)
                {
                    Shell shell = new Shell(player.Top + (player.Height / 2),
                                                player.Left + (player.Width / 2),
                                                10, 10, 1, player.Damage, true, player.Direction);
                    shells.Add(shell);
                    player.timeToShoot = 1500;
                }
            }
            
        }

        public void CheckCollisions()
        {
            EnemyCollidesEnemy();
            EnemyCollidesWall();
            ShellColidesWall();
            EnenemyCollidesBorder();
            PlayerCollidesBorder();
            PlayerCollidesWall();
            ShellColidesPlayer();
            ShellCollidesEnemy();
            PlayerCollidesBonus();
            EnemyCollidesPlayer();
        }
        public void PlayerCollidesBonus()
        {
            for (int i = 0; i < bonuses.Count; i++)
            {
                if (HitBoxCollides(bonuses[i].Left, bonuses[i].Top, bonuses[i].Width, bonuses[i].Height,
                                        player.Left, player.Top, player.Width, player.Height))
                {
                    bonuses.RemoveAt(i);
                    player.Health += 10;
                    score++;
                    labelcountScore.Text = "Score: " + score;
                }
            }
        }
        public void ShellCollidesEnemy()
        {
            for (int i = 0; i < shells.Count; i++)
            {
                if (shells[i].Affiliation == true)
                {
                    for (int j = 0; j < enemies.Count; j++)
                    {
                        if (HitBoxCollides(shells[i].Left, shells[i].Top, shells[i].Width, shells[i].Height,
                                           enemies[j].Left, enemies[j].Top, enemies[j].Width, enemies[j].Height))
                        {
                            enemies[j].Health -= shells[i].Damage;
                        }
                    }
                }
            }
        }
        public void EnemyCollidesPlayer()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                
                
                    if (HitBoxCollides(enemies[i].Left, enemies[i].Top, enemies[i].Width, enemies[i].Height,
                                            player.Left, player.Top, player.Width, player.Height))
                    {
                        player.Health = 0;
                        
                    }
                
            }
        }
        public void ShellColidesPlayer()
        {
            for (int i = 0; i < shells.Count; i++)
            {
                if (shells[i].Affiliation == false)
                {
                    if (HitBoxCollides(shells[i].Left, shells[i].Top, shells[i].Width, shells[i].Height,
                                            player.Left, player.Top, player.Width, player.Height))
                    {
                        player.Health -= shells[i].Damage;
                        shells.RemoveAt(i);
                    }
                }
            }
        }
        public void PlayerCollidesWall()
        {
            for(int i = 0; i < walls.Count; i++)
            {
                if(HitBoxCollides(walls[i].Left, walls[i].Top, walls[i].Width, walls[i].Height,
                                        player.Left, player.Top, player.Width, player.Height))
                {
                    if (player.Direction == Direction.TOP)
                    {
                        player.Top += 2;
                        //enemies[i].Direction = Direction.BOTTOM;
                        //enemies[i].oldDirection = enemies[i].Direction;
                    }
                    else if (player.Direction == Direction.RIGHT)
                    {
                        player.Left -= 2;
                        //enemies[i].Direction = Direction.LEFT;
                        //enemies[i].oldDirection = enemies[i].Direction;
                    }
                    else if (player.Direction == Direction.BOTTOM)
                    {
                        player.Top -= 2;
                        //enemies[i].Direction = Direction.TOP;
                        //enemies[i].oldDirection = enemies[i].Direction;
                    }
                    else if (player.Direction == Direction.LEFT)
                    {
                        player.Left += 2;
                        //enemies[i].Direction = Direction.RIGHT;
                        //enemies[i].oldDirection = enemies[i].Direction;
                    }
                }
            }
        }
        public void PlayerCollidesBorder()
        {
            if ((player.Top + player.Height) > gameMap.Height)
            {
                player.Top = gameMap.Height - player.Height - 2;
            }
            if ((player.Left + player.Width) > gameMap.Width)
            {
                player.Left = gameMap.Width - player.Width - 2;
            }
            if (player.Top < 0)
            {
                player.Top = 2;
            }
            if (player.Left < 0)
            {
                player.Left = 2;
            }
        }
        public void EnenemyCollidesBorder()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if ((enemies[i].Top + enemies[i].Height) > gameMap.Height)
                {
                    enemies[i].Top = gameMap.Height - enemies[i].Height-2;
                }
                if ((enemies[i].Left + enemies[i].Width) > gameMap.Width)
                {
                    enemies[i].Left = gameMap.Width - enemies[i].Width - 2;
                }
                if (enemies[i].Top<0)
                {
                    enemies[i].Top = 2;
                }
                if (enemies[i].Left < 0)
                {
                    enemies[i].Left = 2;
                }

            }
        }
        public void ShellColidesWall()
        {
            for(int i = 0; i < walls.Count; i++)
            {
                for(int j = 0; j < shells.Count; j++)
                {
                    if (HitBoxCollides(walls[i].Left, walls[i].Top, walls[i].Width, walls[i].Height,
                                        shells[j].Left, shells[j].Top, shells[j].Width, shells[j].Height))
                    {

                        walls[i].Health -= shells[j].Damage;
                        shells.RemoveAt(j);
                    }

                    
                }
            }
        }
        public void EnemyCollidesWall()
        {
            for(int i = 0; i < enemies.Count; i++)
            {
                for(int j = 0; j < walls.Count; j++)
                {
                    if (HitBoxCollides(enemies[i].Left, enemies[i].Top, enemies[i].Width, enemies[i].Height,
                                        walls[j].Left, walls[j].Top, walls[j].Width, walls[j].Height))
                    {
                        if (enemies[i].Direction == Direction.TOP)
                        {
                            enemies[i].Top+=2;
                            //enemies[i].Direction = Direction.BOTTOM;
                            //enemies[i].oldDirection = enemies[i].Direction;
                        }
                        else if(enemies[i].Direction == Direction.RIGHT)
                        {
                            enemies[i].Left-=2;
                            //enemies[i].Direction = Direction.LEFT;
                            //enemies[i].oldDirection = enemies[i].Direction;
                        }
                        else if (enemies[i].Direction == Direction.BOTTOM)
                        {
                            enemies[i].Top-=2;
                            //enemies[i].Direction = Direction.TOP;
                            //enemies[i].oldDirection = enemies[i].Direction;
                        }
                        else if (enemies[i].Direction == Direction.LEFT)
                        {
                            enemies[i].Left+=2;
                            //enemies[i].Direction = Direction.RIGHT;
                            //enemies[i].oldDirection = enemies[i].Direction;
                        }
                    }
                }
            }
        }
        public void EnemyCollidesEnemy()
        {
            for(int i = 0; i < enemies.Count; i++)
            {
                for(int j = 0; j < enemies.Count; j++)
                {
                    if(HitBoxCollides(enemies[i].Left,enemies[i].Top,enemies[i].Width,enemies[i].Height,
                        enemies[j].Left, enemies[j].Top, enemies[j].Width, enemies[j].Height))
                    {
                        if (enemies[i].Direction == Direction.TOP)
                        {
                            enemies[i].Direction = Direction.BOTTOM;
                            enemies[i].Top += 2;
                        }
                        else if (enemies[i].Direction == Direction.RIGHT)
                        {
                            enemies[i].Direction = Direction.LEFT;
                            enemies[i].Left -= 2;
                        }
                        else if (enemies[i].Direction == Direction.BOTTOM)
                        {
                            enemies[i].Direction = Direction.TOP;
                            enemies[i].Top -= 2;
                        }
                        else if (enemies[i].Direction == Direction.LEFT)
                        {
                            enemies[i].Direction = Direction.RIGHT;
                            enemies[i].Left += 2;
                        }

                        if (enemies[j].Direction == Direction.TOP)
                        {
                            enemies[j].Direction = Direction.BOTTOM;
                            enemies[j].Top += 2;
                        }
                        else if (enemies[j].Direction == Direction.RIGHT)
                        {
                            enemies[j].Direction = Direction.LEFT;
                            enemies[j].Left -= 2;
                        }
                        else if (enemies[j].Direction == Direction.BOTTOM)
                        {
                            enemies[j].Direction = Direction.TOP;
                            enemies[j].Top -= 2;
                        }
                        else if (enemies[j].Direction == Direction.LEFT)
                        {
                            enemies[j].Direction = Direction.RIGHT;
                            enemies[j].Left += 2;
                        }
                    }
                }
            }
        }
        public bool HitBoxCollides(float x, float y, float width, float height,
                                    float x2, float y2, float width2, float height2)
        {
            bool yes = Collides(x, y, x + width, y + height, x2, y2, x2 + width2, y2 + height2);
            return yes;
        }
        public bool Collides(float x, float y, float right, float bottom,
                            float x2, float y2, float right2, float bottom2)
        {
            return !((right <= x2) || (x > right2) || (bottom <= y2) || (y > bottom2));
        }

        private void timeRefresh_Tick(object sender, EventArgs e)
        {
            gameMap.CreateSubject(bitmap);

            UpdateGameObjects();
            for (int i = 0; i < walls.Count; i++)
            {
                walls[i].CreateSubject(bitmap);
            }
            for (int i = 0; i < shells.Count; i++)
            {
                shells[i].CreateSubject(bitmap);
            }
            for (int i = 0; i < bonuses.Count; i++)
            {
                bonuses[i].CreateSubject(bitmap);
            }
            
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].CreateSubject(bitmap);
            }
            player.CreateSubject(bitmap);
            pBGameField.Image = bitmap;
            OnTransferInfo?.Invoke(this, new ReportEventArgs(player, enemies, bonuses));
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            BonusesCount = tbBonus.Value;
            enemiesCount = tbEnemy.Value;
            mapHeight = tbMapHeight.Value;
            speed = tbSpeed.Value;
            mapWidth = tbMapWidth.Value;
            btnGameStart.Enabled = true;
        }

        private void btnGameStart_Click(object sender, EventArgs e)
        {
            tbBonus.Visible = false;
            tbEnemy.Visible = false;
            tbMapHeight.Visible = false;
            tbMapWidth.Visible = false;
            tbSpeed.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnGameStart.Visible = false;
            btnParameters.Visible = false;
            GameStart(speed, 30, enemiesCount, 30, 30, BonusesCount);
        }

        private void labelReport_Click(object sender, EventArgs e)
        {

            Form form = new FormReport(this);
            form.Show();
        }
    }
}
