using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armors : Items
{

    public Armors(string name, int price, int weight)
    {
        Name = name;
        Price = price;
        Weight = weight;
    }

    public override void Discard()
    {
        Debug.Log("An armor discarded");
    }

}
