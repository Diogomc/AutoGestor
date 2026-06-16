namespace AutoGestor.Models;

public class WorkOrder
{
    public int WorkOrderId { get; set; }
    public string Complaint {get; set;}
    public string RequestedServices { get; set; }
    public string Diagnostic { get; set; }

    public Client Client { get; set; }
    public int ClientId { get; set; }

    public Vehicle Vehicle { get; set; }
    public int VehicleId { get; set; }

}
