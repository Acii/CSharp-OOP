﻿using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class Microphone : Article, IMicrophone
    {
        private bool hasCable;
        public Microphone(string make, string model, decimal price, bool hasCable) : base(make, model, price)
        {
            this.HasCable = hasCable;
        }
        public bool HasCable
        {
            get 
            {
                return this.hasCable;
            }
            private set
            {
                this.hasCable = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString())
                .AppendFormat("Cable: {0}", this.HasCable ? "yes" : "no").AppendLine();
            return result.ToString();
        }
    }
}
