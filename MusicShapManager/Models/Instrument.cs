using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class Instrument : Article, IInstrument
    {
        private string color;
        private bool isElectronic;
        public Instrument (string make, string model, decimal price, string color, bool isElectronic) : base(make, model, price)
        {
            this.Color = color;
            this.IsElectronic = isElectronic;
        }
        public string Color
        {
            get 
            {
                return this.color;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Color is requred");
                }
                this.color = value;
            }
        }

        public bool IsElectronic
        {
            get 
            {
                return this.isElectronic;
            }
            private set
            {
                this.isElectronic = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString())
                .AppendFormat("Color: {0}", this.Color).AppendLine()
                .AppendFormat("Electronic: {0}", this.IsElectronic ? "yes" : "no").AppendLine();
            return result.ToString();
        }
    }
}
