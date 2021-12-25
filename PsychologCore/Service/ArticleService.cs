using PsychologCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologCore.Service
{
    public interface IArticleService
    {
        List<Article> GetArticles();
    }

    public class ArticleService : IArticleService
    {
        public ArticleService()
        {
            // any DI .. in future
        }
        public List<Article> GetArticles()
        {
            var rand = new Random();
            var count = rand.Next(10, 100);

            var list = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                var id = Guid.NewGuid();

                var item = new Article
                {
                    Id = id,
                    Name = $"Article {id.ToString().Substring(0, 5)}",
                    Content = $"this is article {id} . . .",
                    Author = $"System",
                    Created = DateTime.Now.AddDays(-rand.Next(1, 100)),
                    IsHidden = false,
                    Tags = new string[] { "tag1", "tag2" },
                    Views = rand.Next(1, 10000),
                    Updated = null
                };

                list.Add(item);
            }

            return list;
        }
    }
}
