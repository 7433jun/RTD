using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BattleManager : Singleton<BattleManager>
{
    public List<Character> allys = new List<Character>();
    public List<Character> enemys = new List<Character>();

    public bool isBattleEnd = false;

    public void Battle1()
    {
        isBattleEnd = false;

        foreach (var ally in allys)
        {
            ally.BattleStart();
        }

        enemys[0].gameObject.SetActive(true);

        StartCoroutine(CheckBattleEnd());
    }

    public Character RandomAlly()
    {
        return allys[Random.Range(0, allys.Count)];
    }
    
    IEnumerator CheckBattleEnd()
    {
        while (true)
        {
            bool allDead = true;
            foreach (var enemy in enemys)
            {
                if (!enemy.isDead)
                {
                    allDead = false;
                    break;
                }
            }

            if (allDead)
            {
                isBattleEnd = true;

                StageManager.instance.OpenReward();
                yield break;
            }

            yield return null;
        }
    }
}
