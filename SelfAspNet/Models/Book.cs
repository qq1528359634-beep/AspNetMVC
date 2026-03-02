namespace SelfAspNet_MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; } = string.Empty;
        public string  Title { get; set; }= string.Empty;
        public int Price { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public DateTime Published { get; set; }
        public bool Sample { get; set; } 
    }
}
