using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class BassGuitar : Guitar, IBassGuitar
    {
        public BassGuitar(string make, string model, decimal price,
            string color, string bodyWood, string fingerboardWood)
            : base(make, model, price, color, true, bodyWood, fingerboardWood, numberOfStrings : 4)
        {

        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString())
                .AppendFormat("Body wood: {0}", this.BodyWood).AppendLine()
                .AppendFormat("Fingerboard wood: {0}", this.FingerboardWood).AppendLine();
            return result.ToString();
        }
    }
}
