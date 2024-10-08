using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class ItemData
{
    [Key]
    public string ItemId { get; set; }
    public string ItemName { get; set; } 
    public int Price { get; set; }
    public ItemData()
    {
        ItemId = Guid.NewGuid().ToString();
    }
}