using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNet.API.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }

        public int ListId { get; set; }

        public List List { get; set; }
    }
}
