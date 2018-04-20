using System;
using System.Collections.Generic;

namespace Addressbook.Models
{
public class Address
{
  private string _name;
  private string _address;
  private string _phonenumber;
  public static List<Address> _instances = new List<Address>() {};

  public string Getname()
  {
    return _name;
  }
    public void Save()
  {
    _instances.Add(this);
  }

  public void Setname(string newname)
  {
    _name = newname;
  }

  public string Getaddress()
  {
    return _address;
  }

  public void Setaddress(string newaddress)
  {
    _address = newaddress;
  }
  public string Getphone()
  {
    return _phonenumber;
  }

  public void Setphone(string newphone)
  {
    _phonenumber = newphone;
  }
  public static void ClearAll()
 {
      _instances.Clear();
 }

  public static List<Address> Getall()
  {

      return _instances;
}

}

}