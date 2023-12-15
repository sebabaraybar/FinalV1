using FinalV1.Models;

namespace FinalV1.ViewModels;

public class MenuViewModel
{
    public List<Menu> Menus { get; set; } = new List<Menu>();
    public string? NameFilter { get; set; }
}