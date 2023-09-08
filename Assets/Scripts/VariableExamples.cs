using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExamples : MonoBehaviour
{

    Items sword;
    Items shield;

    private void Start()
    {

        sword = new Items("Battlecry", 100, 10);
        shield = new Items("Sunlight", 50, 30);

        Debug.Log(sword.Price);
        sword.Price = 75;
        sword.Info();

        Debug.Log(shield.Weight);
        shield.Weight = 100;
        shield.Info();

    }
}
