namespace AutoGestor.Models;

public class WorkOrder
{
    public string Complaint {get; set;}
    public string RequestedServices { get; set; }
    public string Diagnostic { get; set; }
    public Client client { get; set; }
    public Vehicle vehicle { get; set; }

}
