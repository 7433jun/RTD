using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
    public Character character;

    public string skillName;
    public float useE;

    public void Act()
    {
        Damage();
        SetE();
        Buff();
    }

    public abstract void Damage();

    public abstract void SetE();

    public abstract void Buff();
}
