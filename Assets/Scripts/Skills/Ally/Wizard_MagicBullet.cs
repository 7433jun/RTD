using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard_MagicBullet : Skill
{
    public Wizard_MagicBullet(Character _character)
    {
        character = _character;

        skillName = "����ź";
        useE = 1.0f;
    }


    public override void Damage()
    {
        Debug.Log("����ź");
        BattleManager.instance.enemys[0].GetComponent<Character>().currentHp -= character.magicPower;
    }

    public override void SetE()
    {
        character.currentE -= useE;
    }

    public override void Buff()
    {
        
    }
}
