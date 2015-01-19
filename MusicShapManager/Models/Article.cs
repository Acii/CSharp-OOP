using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class Article : IArticle
    {
        private string make;
        private string model;
        private decimal price;
        public Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
        public string Make
        {
            get 
            {
                return this.make;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The make is requred");
                }
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model is requred");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get 
            {
                return this.price;
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be positive");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("= {0} {1} =", this.Make, this.Model).AppendLine()
                .AppendFormat("Price: ${0:F2}", this.Price).AppendLine();
            return result.ToString();
        }
    }
}
