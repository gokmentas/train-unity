using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExamples : MonoBehaviour
{

    private void Start()
    {

        //Armors armor1 = new Armors("chainmail", 300, 50);
        //Armors armor2 = new Armors("templer's armor", 500, 55);

        ////Debug.Log(armor1.Weight);
        ////Debug.Log(armor2.Name);
        ////armor1.Price = 1000;
        ////Debug.Log(armor1.Price);

        ////armor1.Info();
        ////armor2.Info();

        //armor1.Discard();

        Spells spell1 = new Spells("Baleful Strike", "Veigar blasts a dark bolt in the target direction that deals magic damage to the first two enemies hit.", 30, 80);
        Spells spell2 = new Spells("Dark Matter", "Veigar casts down a mass of dark matter that strikes the target location after a 1.221 seconds delay, dealing magic damage to enemies hit.", 60, 85);

        spell1.Info();
        spell2.Info();

    }
}
