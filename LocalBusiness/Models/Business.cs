using System.ComponentModel.DataAnnotations;

namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId {get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Genre { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
  }
}