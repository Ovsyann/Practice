using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame
{
    public class Explosion : GameObject
    {
        public Explosion(float left,float top,float width,float height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }
        public Image image=Properties.Resources.Explosion1;
        public int timeOfExplosion=0;
        public override void CreateSubject(Bitmap bitmap)
        {
            if (timeOfExplosion <= 100)
                image = Properties.Resources.Explosion1;
            else if ((timeOfExplosion >= 100) && (timeOfExplosion <= 300))
                image = Properties.Resources.Explosion2;
            else if ((timeOfExplosion >= 300) && (timeOfExplosion <= 500))
                image = Properties.Resources.Explosion3;
            else if ((timeOfExplosion >= 500) && (timeOfExplosion <= 700))
                image = Properties.Resources.Explosion4;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, Left, Top, Width, Height);
        }
    }
}
