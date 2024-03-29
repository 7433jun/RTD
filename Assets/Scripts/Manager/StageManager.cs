using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : Singleton<StageManager>
{
    [SerializeField] GameObject reward;

    public void StartStage(int userLocate)
    {
        switch(userLocate)
        {
            case 1:
                BattleManager.instance.Battle1();
                break;
            case 2:
                SituationManager.instance.situation1();
                break;
            case 3:
                SituationManager.instance.TreasureBox1();
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            default:
                break;
        }
    }

    public void OpenReward()
    {
        reward.SetActive(true);
    }

    public void EndStage()
    {
        if (SituationManager.instance.treasureBox.activeSelf == true)
        {
            SituationManager.instance.treasureBox.SetActive(false);
        }
        reward.SetActive(false);
        GameManager.instance.Map();
    }
}
