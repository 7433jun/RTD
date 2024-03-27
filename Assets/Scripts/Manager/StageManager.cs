using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField] GameObject reward;

    public void StartStage(int userLocate)
    {
        switch(userLocate)
        {
            case 1:
                break;
            default:
                break;
        }
    }

    private void OpenReward()
    {
        reward.SetActive(true);
    }

    public void EndStage()
    {
        reward.SetActive(false);
        GameManager.instance.Map();
    }
}
