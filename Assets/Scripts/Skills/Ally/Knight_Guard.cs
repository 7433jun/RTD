using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Guard : Skill
{
    public Knight_Guard(Character _character)
    {
        character = _character;

        skillName = "막기";
        useE = 10.0f;
    }


    public override void Damage()
    {
        Debug.Log("막기");
    }

    public override void SetE()
    {
        character.currentE = 0;
        character.maxE = useE;
    }

    public override void Buff()
    {

    }
}
