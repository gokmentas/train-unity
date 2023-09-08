using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{

    string name;
    int price;
    float weight;

    public Items(string name, int price, int weight)
    {
        this.name = name;
        this.price = price;
        this.weight = weight;
    }

    public void Info()
    {
        Debug.Log($"{name} {price} {weight}");
    }

    public bool Worth()
    {
        return (price >= weight * 10);
    }

}
