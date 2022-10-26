namespace FrontBackEShopers.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Price { get; set; }   

        public override string ToString()
        {
            return $"{Id} {Name} {ImageUrl} {Price}" ;
        }
    }
}
