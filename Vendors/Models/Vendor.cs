using System.Collections.Generic;

namespace CafeVendors.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _vendorList = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = "";
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order> {};
    }

  }
}

// Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.