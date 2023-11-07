using System.Text;
using System.Xml.Linq;

namespace PrimeiroProjeto.Classes.Post
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments = new List<Comment>();

        public Post() { }
        public Post(DateTime moment, string title, string content, int likes)
        {
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = likes;
        }

        public void AddComment(Comment comment) { Comments.Add(comment); }

        /* Correção
        public void RemoveComment(Comment comment) { Comments.Remove(comment); } */

        public void ShowComments()
        {
            foreach (Comment comment in Comments)
            {
                Console.WriteLine(comment.text);
            }
        }

        public override string ToString()
        {
            return Title + "\n" + Likes + " - " + Moment + "\n" + Content + "\n Comments: " + ShowComments;
        }

        /* Correção
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy hh:mmss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.text);
            }
            
            return sb.ToString();
        }*/
    }
}
