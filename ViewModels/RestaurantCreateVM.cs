using FinalV1.Models;
namespace FinalV1.ViewModels;
public class RestaurantCreateVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public List<int> MenuIds { get; set; }
}
