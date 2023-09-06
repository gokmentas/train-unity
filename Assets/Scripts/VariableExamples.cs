using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExamples : MonoBehaviour
{

    private void Start()
    {

        string name = "mbappe";

        float goals = 30;
        float matches = 48;
        float goalPerMatch = matches / goals;

        //Debug.Log(name + " scored " + goalPerMatch + " per match");
        Debug.Log($"{name} scored {goalPerMatch} per match");

    }

}
