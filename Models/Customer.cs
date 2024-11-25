
namespace AspProjectOne.Models;
public class Customer
{
    // Customer sınıfı oluşturuldu
    public int Id { get; set; } 
    // Customer sınıfı için özellikler tanımlandı
    // Customer sınıfı için varsayılan değerler atandı
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}