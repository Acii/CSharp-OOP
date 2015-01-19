using MusicShopManager.Interfaces;
using MusicShopManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class AcousticGuitar : Guitar, IAcousticGuitar
    {
        private bool caseIncluded;
        private StringMaterial stringMaterial;

        public AcousticGuitar(string make, string model, decimal price,
            string color, string bodyWood, string fingerboardWood,
            bool caseIncluded, StringMaterial stringMaterial) :
            base(make, model, price, color, false, bodyWood, fingerboardWood, numberOfStrings: 6)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
        }

        public StringMaterial StringMaterial
        {
            get
            {
                return this.stringMaterial;
            }
            private set
            {
                this.stringMaterial = value;
            }
        }
      
        public bool CaseIncluded
        {
            get
            {
                return this.caseIncluded;
            }
            private set
            {
                this.caseIncluded = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString())
                .AppendFormat("Body wood: {0}", this.BodyWood).AppendLine()
                .AppendFormat("Fingerboard wood: {0}", this.FingerboardWood).AppendLine()
                .AppendFormat("Case included: {0}", this.CaseIncluded ? "yes" : "no").AppendLine()
                .AppendFormat("String material: {0}", this.StringMaterial).AppendLine();
            return result.ToString();
        }
    }
}
