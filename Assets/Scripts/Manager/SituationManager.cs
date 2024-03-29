using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SituationManager : Singleton<SituationManager>
{
    [SerializeField] GameObject situationWindow;
    [SerializeField] List<Button> options;

    public GameObject treasureBox;

    public void situation1()
    {
        situationWindow.SetActive(true);

        options[0].onClick.AddListener(situation1_option1);
        options[1].onClick.AddListener(situation1_option2);
    }

    private void situation1_option1()
    {
        BattleManager.instance.RandomAlly().currentHp -= 30;
        situationWindow.SetActive(false);
        StageManager.instance.EndStage();
    }

    private void situation1_option2()
    {
        situationWindow.SetActive(false);
        StageManager.instance.EndStage();
    }

    public void TreasureBox1()
    {
        treasureBox.SetActive(true);
    }
}
