using System;
using System.Text;

namespace HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            StringBuilder HTML = new StringBuilder();
            StringBuilder title = new StringBuilder();
            title.Append(Console.ReadLine());
            StringBuilder article = new StringBuilder();
            article.Append(Console.ReadLine());
            HTML.Append($"<h1>\n    {title}\n</h1>\n");
            HTML.Append($"<article>\n    {article}\n</article>\n");
            StringBuilder comments = new StringBuilder();
            comments.Append(Console.ReadLine());
            while (comments.ToString() != "end of comments")
            {
                HTML.Append($"<div>\n    {comments}\n</div>\n");
                comments.Clear().Append(Console.ReadLine());
            }

            Console.WriteLine(HTML.ToString().TrimEnd('\n'));
        }
    }
}