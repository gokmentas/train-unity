using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExamples : MonoBehaviour
{

    private void Start()
    {
        //int charisma = 45;
        //int style = 45;

        //if (charisma <= 0)
        //{
        //    Debug.Log("Did you juts come out from a cave?");
        //}
        //else if (charisma >= 100 || style >= 100)
        //{
        //    Debug.Log("You can date with Angelina");
        //}else if (charisma >= 70 &&  style >= 50)
        //{
        //    Debug.Log("You can date with Sarah");
        //}else if(charisma <= 40 || style <= 40)
        //{
        //    Debug.Log("You can't date with anyone");
        //}
        //else
        //{
        //    Debug.Log("You can date with Marry");
        //}

        string spell = "resistance";
        int money = 30;

        switch (spell)
        {
            case "resistance":
                Debug.Log("Magically bolster a creature's defences. It receives a +1d4 bonus to Saving Throws.");
                break;
            case "fire bolt":
                Debug.Log("Hurl a mote of fire.");
                break;
            default:
                Debug.Log("Wrong selection");
                break;
        }

    }

}
