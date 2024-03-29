using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_BodyAttack : Skill
{
    public Slime_BodyAttack(Character _character)
    {
        character = _character;

        skillName = "몸통박치기";
        useE = 4.0f;
    }

    public override void Damage()
    {
        Debug.Log("몸통박치기");
        BattleManager.instance.RandomAlly().GetComponent<Character>().currentHp -= character.physicalPower;
    }

    public override void SetE()
    {
        character.currentE = 0f;
    }

    public override void Buff()
    {
        
    }
}
