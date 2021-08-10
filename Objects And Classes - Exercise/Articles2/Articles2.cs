using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Articles2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine().Split(", ");
                Article newArticle = new Article(articleData[0], articleData[1], articleData[2]);
                articles.Add(newArticle);
            }

            string orderType = Console.ReadLine();
            switch (orderType)
            {
                case "title":
                    articles = articles.OrderBy(art => art.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(art => art.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(art => art.Author).ToList();
                    break;
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
            => $"{Title} - {Content}: {Author}";
    }
}
