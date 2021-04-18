namespace EShop.Domain.Models
{
    public interface IProduct
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        string PhotoUrl { get; set; }
        double Price { get; set; }
    }
}