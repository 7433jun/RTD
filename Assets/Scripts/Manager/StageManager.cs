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
            case 2:
                break;
            case 3:
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
