using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Slash : Skill
{
    public Knight_Slash(Character _character)
    {
        character = _character;

        skillName = "베기";
        useE = 5.0f;
    }


    public override void Damage()
    {
        Debug.Log("베기");
        BattleManager.instance.enemys[0].GetComponent<Character>().currentHp -= character.physicalPower;
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
