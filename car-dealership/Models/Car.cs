using System;

namespace Dealership.Models
{

  public class Car
  {
    private string _makeModel;
    private float _price;
    private int _miles;

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public float SetPrice()
    {
      float newPrice = Convert.ToSingle(_price * .9);
      return newPrice;
    }


    public string GetMakeModel()
    {
      return _makeModel;
    }

    public float GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }
}
