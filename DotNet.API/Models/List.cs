namespace DotNet.API.Models
{
    public class List
    {
        public int ListId { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}
