using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TanksGame
{
    public abstract class GameObject
    {
        protected int[,] Size
        {
            get
            {
                return Size;
            }
            set
            {
                Size = value;
            }
        }
        protected int[,] Position
        {
            get
            {
                return Position;
            }
            set
            {
                Position = value;
            }
        }
        protected Bitmap Bitmap
        {
            get
            {
                return Bitmap;
            }
            set
            {
                Bitmap = value;
            }
        }
        protected int Health
        {
            get
            {
                return Health;
            }
            set
            {
                Health = value;
            }
        }
    }
}
