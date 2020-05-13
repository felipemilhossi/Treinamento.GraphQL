using GraphQL.Infraestructure.Data.Database.Entity;

namespace GraphQL.Infraestructure.Data.Database
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Published { get; set; }
        public virtual Company Author { get; set; }
    }
}
