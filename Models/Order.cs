namespace AspProjectOne.Models;
public class Order
{
    // Order sınıfı oluşturuldu
    // Order sınıfı için özellikler tanımlandı
    
    public int Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}