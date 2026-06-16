namespace AutoGestor.Models;

public class Vehicle
{
    public int VehicleId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string ProductionYear { get; set; }
    public string Color { get; set; }
    public string Plate { get; set; }

    public Client Client { get; set; }
    public int ClientId { get; set; }

    public ICollection<WorkOrder> WorkOrders { get; set; }

}
