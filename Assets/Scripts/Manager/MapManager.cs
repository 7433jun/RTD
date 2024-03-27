using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] GameObject[] buttons;

    public void MoveToStage()
    {
        if (buttons[GameManager.instance.userLocate] == EventSystem.current.currentSelectedGameObject)
        {
            GameManager.instance.userLocate++;
            Debug.Log($"Stage : {GameManager.instance.userLocate}");
            map.SetActive(false);
            GameManager.instance.Stage();
        }
    }

    public void OpenMap()
    {
        map.SetActive(true);
    }
}
