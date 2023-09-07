using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExamples : MonoBehaviour
{

    private void Start()
    {
        ApparenceTime();
    }

    IEnumerator CanBeAlly()
    {
        Debug.Log("I will give you 5 seconds");
        yield return new WaitForSeconds(5);
        Debug.Log("Attack");
    }

    bool IsEnnemy = false;

    void ApparenceTime()
    {
        if (IsEnnemy)
        {
            Debug.Log("Attack");
        }
        else
        {  
            StartCoroutine(CanBeAlly());   
        }
    }
}
