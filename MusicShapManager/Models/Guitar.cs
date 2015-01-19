using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class Guitar : Instrument, IGuitar
    {
        private string bodyWood;
        private string fingerboardWood;
        private int numberOfStrings;

        public Guitar(string make, string model, decimal price, 
            string color, bool isElectronic, string bodyWood,
            string fingerboardWood, int numberOfStrings) :
            base(make, model, price, color, isElectronic)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
            this.NumberOfStrings = numberOfStrings;
        }
        public string BodyWood
        {
            get 
            {
                return this.bodyWood;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The body is requred");
                }
                this.bodyWood = value;
            }
        }

        public string FingerboardWood
        {
            get 
            {
                return this.fingerboardWood;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Finger board is requred");
                }
                this.fingerboardWood = value;
            }
        }

        public int NumberOfStrings
        {
            get 
            {
                return this.numberOfStrings;
            }
            private set
            {
                this.numberOfStrings = value;
            }
        }

        public override string ToString()
        {
           var result = new StringBuilder();
           result.Append(base.ToString())
               .AppendFormat("Strings: {0}", this.NumberOfStrings).AppendLine();
           return result.ToString();
        }
    }
}
