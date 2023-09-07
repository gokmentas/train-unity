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
        //Debug.Log($"{name} scored {goalPerMatch} per match");

        Debug.Log($"Can player cast spell{5}?" + CanCastSpell(5, 500));  
        StoredMana(5);

    }

    bool CanCastSpell(int spellId, float mana)
    {
        return true;
    }

    void StoredMana(int spellId)
    {
        float mana = 1000;
        float usedMmana = spellId * 40;
        mana -= usedMmana;
        Debug.Log($"When player used {spellId} spell, remaining mana is: {mana}");
    }

}
