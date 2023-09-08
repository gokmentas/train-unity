using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spells
{

    private string _spellName;
    private string _spellDescription;
    private int _requiredMana;
    private int _damage;

    public string SpellName
    {
        get { return _spellName; }
        set { _spellName = value; }
    }

    public string SpellDescription
    {
        get { return _spellDescription; }
        set { _spellDescription = value; }
    }

    public int RequiredMana
    {
        get { return _requiredMana; }
        set { _requiredMana = value; }
    }

    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    public Spells()
    {

    }

    public Spells(string spellName, string spellDescription, int requairedMana, int damage)
    {
        SpellName = spellName;
        SpellDescription = spellDescription;
        RequiredMana = requairedMana;
        Damage = damage;
    }

    public void Info()
    {
        Debug.Log($"{SpellName}: {SpellDescription}\nDamage: {Damage} Cost: {RequiredMana}");
    }

}
