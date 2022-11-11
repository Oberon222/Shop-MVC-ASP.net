using System.ComponentModel.DataAnnotations;

namespace Shop_MVC2.Models
{
  public class Category
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int ShowOrder { get; set; }
  }
}
