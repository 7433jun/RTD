using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop_heal : Skill
{
    public Bishop_heal(Character _character)
    {
        character = _character;

        skillName = "Èú";
        useE = 20.0f;
    }


    public override void Damage()
    {
        Debug.Log("Èú");

        Character target = BattleManager.instance.RandomAlly().GetComponent<Character>();
        target.currentHp += character.magicPower / 2;
        if (target.currentHp > target.maxHp)
        {
            target.currentHp = target.maxHp;
        }
    }

    public override void SetE()
    {
        character.currentE -= useE;
    }

    public override void Buff()
    {

    }
}
