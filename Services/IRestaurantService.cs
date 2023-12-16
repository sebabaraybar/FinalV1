namespace FinalV1.Services;

public interface IRestaurantService
{
    void Create(Restaurant obj);
    List<Restaurant> GetAll();
    void Update(Restaurant obj);
    void Delete(Restaurant obj);
    Restaurant GetById(int id);
}