namespace InventoryManagement.Models.Northwind;

public class OrdersType
{
    public double OrderID { get; set; }
    public string CustomerID { get; set; }
    public double EmployeeID { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime ShippedDate { get; set; }
    public double ShipVia { get; set; }
    public double Freight { get; set; }
    public string ShipName { get; set; }
    public ShipAddressType ShipAddress { get; set; } = new();
    public DetailsType[] Details { get; set; } = Array.Empty<DetailsType>();
}
