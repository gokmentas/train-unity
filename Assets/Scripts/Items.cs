using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    
    private string _name;
    private int _price;
    private int _weight;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }

    public Items()
    {

    }

    public Items(string name, int price, int weight)
    {
        Name = name;
        Price = price;
        Weight = weight;
    }

    public void Info()
    {
        Debug.Log($"Name: {Name} Price: {Price} Weight: {Weight}");
    }

    public virtual void Discard()
    {
        Debug.Log("Item discarded");
    }

}
