using MusicShopManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class MusicShopBase : IMusicShop
    {
        private string name;
        private IList<IArticle> articles;

        public MusicShopBase(string name)
        {
            this.Name = name;
            this.Articles = new List<IArticle>();
        }
        public string Name
        {
            get 
            {
                return this.name;
            }
            private set 
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Name is requred");
                }
                this.name = value;
            }
        }

        public IList<IArticle> Articles
        {
            get 
            {
                return this.articles;
            }
            private set
            {
                this.articles = value;
            }
        }

        public void AddArticle(IArticle article)
        {
            this.Articles.Add(article);
        }

        public void RemoveArticle(IArticle article)
        {
            this.Articles.Remove(article);
        }

        public string ListArticles()
        {
            var result = new StringBuilder();
            result.AppendFormat("{0} {1} {0}", new string('=', 5), this.Name).AppendLine();
            if (this.Articles.Count == 0)
            {
                result.Append("The shop is empty. Come back soon.");
            }
            else
            {
                var catalog = new List<string>();

                var microphone = this.Articles.Where(a => a is IMicrophone);
                AppendArticlesToList(catalog, "Microphones", microphone);

                var drums = this.Articles.Where(r => r is IDrums);
                AppendArticlesToList(catalog, "Drums", drums);

                var electricGuitar = this.Articles.Where(a => a is IElectricGuitar);
                AppendArticlesToList(catalog, "Electric guitars", electricGuitar);

                var acousticGuitar = this.Articles.Where(a => a is IAcousticGuitar);
                AppendArticlesToList(catalog, "Acoustic guitars", acousticGuitar);

                var bassGuitars = this.Articles.Where(a => a is IBassGuitar);
                AppendArticlesToList(catalog, "Bass guitars", bassGuitars);

                result.Append(string.Join(Environment.NewLine, catalog));

            }

            return result.ToString();
        }
        private void AppendArticlesToList(List<string> listArticles, string title, IEnumerable<IArticle> articles)
        {
            if (articles.Any())
            {
                var sortedArticles = articles.OrderBy(a => a.Make)
                        .ThenBy(a => a.Model);
                var articlesStr = string.Format("{0} {1} {0}{2}{3}",
                    new string('-', 5),
                    title,
                    Environment.NewLine,
                    string.Join("", sortedArticles));
                listArticles.Add(articlesStr.Trim());
            }
        }
    }
}
