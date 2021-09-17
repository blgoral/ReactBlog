namespace ReactBlogApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PostBody { get; set; }
        public string Author { get; set; }
        public bool IsPublished { get; set; }
    }
}