using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class Drums : Instrument, IDrums
    {
        private int width;
        private int height;

        public Drums(string make, string model, decimal price, string color, int width, int height)
            : base(make, model, price, color, false)
        {
            this.width = width;
            this.height = height;
        }
        public int Width
        {
            get 
            {
                return this.width;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The width must be positive");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get 
            {
                return this.height;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The height must be positive");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString())
                .AppendFormat("Size: {0}cm x {1}cm", this.Width, this.Height).AppendLine();
            return result.ToString();
        }
    }
}
