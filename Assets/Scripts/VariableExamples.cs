using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExamples : MonoBehaviour
{

    private void Start()
    {
        Items item1 = new Items("sword", 100, 10);
        Items item2 = new Items("shield", 30, 20);

        item1.Info();
        item2.Info();

        Debug.Log($"Worth it to take? {item1.Worth()}");
        Debug.Log($"Worth it to take? {item2.Worth()}");

    }
}
