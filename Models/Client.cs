namespace AutoGestor.Models;

public class Client
{
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public ICollection<Vehicle> Vehicles { get; set; }
    public ICollection<WorkOrder> WorkOrders { get; set; }
}
