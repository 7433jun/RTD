using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] StageManager stageManager;
    [SerializeField] MapManager mapManager;

    public int userLocate;

    void Start()
    {
        userLocate = 0;
    }

    public void Stage()
    {
        stageManager.StartStage(userLocate);
    }

    public void Map()
    {
        mapManager.OpenMap();
    }
}
