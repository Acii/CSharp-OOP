using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class ElectricGuitar : Guitar, IElectricGuitar
    {
        private int numberOfAdapters;
        private int numberOfFrets;

        public ElectricGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood,
             int numberOfAdapters, int numberOfFrets) :
            base(make, model, price, color, true, bodyWood, fingerboardWood, numberOfStrings: 6)
        {
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
        }

        public int NumberOfAdapters
        {
            get 
            {
                return this.numberOfAdapters;
            }
            private set
            {
                this.numberOfAdapters = value;
            }
        }

        public int NumberOfFrets
        {
            get 
            {
                return this.numberOfFrets;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of frets must be positive");
                }
                this.numberOfFrets = value;
            }
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString())
                .AppendFormat("Body wood: {0}", this.BodyWood).AppendLine()
                .AppendFormat("Fingerboard wood: {0}", this.FingerboardWood).AppendLine()
                .AppendFormat("Adapters: {0}", this.NumberOfAdapters).AppendLine()
                .AppendFormat("Frets: {0}", this.NumberOfFrets).AppendLine();
            return result.ToString();
        }
    }
}
