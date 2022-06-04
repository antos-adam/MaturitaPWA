using System.ComponentModel.DataAnnotations;

namespace _21DB.Model
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
