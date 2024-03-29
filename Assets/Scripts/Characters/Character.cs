using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public int physicalPower;
    public int magicPower;
    public int currentHp;
    public int maxHp;
    // E : Energy;
    public float regenE;
    public float currentE;
    public float maxE;
    public bool isDead;

    public void SetStatus(int _physicalPower, int _magicPower, int _maxHp, float _regenE, float _maxE)
    {
        physicalPower = _physicalPower;
        magicPower = _magicPower;
        maxHp = _maxHp;
        currentHp = _maxHp;
        regenE = _regenE;
        maxE = _maxE;
        currentE = 0;
    }

    public void BattleStart()
    {
        StartCoroutine(RegenEnergy());
    }

    public IEnumerator RegenEnergy()
    {
        while (true)
        {
            currentE = currentE + regenE * Time.deltaTime;
            if (currentE > maxE)
            {
                currentE = maxE;
            }

            // Á¾·á
            if (currentHp <= 0 || BattleManager.instance.isBattleEnd)
            {
                currentE = 0;
                yield break;
            }

            yield return null;
        }
    }
}
