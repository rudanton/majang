using System.ComponentModel.DataAnnotations;

public class SaleData
{
    [Key]
    public DateTime SaleDate { get; set; }
    public string DictionaryJson { get; set; }
}