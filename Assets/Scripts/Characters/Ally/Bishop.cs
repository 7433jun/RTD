using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bishop : Character
{
    [SerializeField] GameObject uiPoint;

    TextMeshProUGUI skillName;
    Slider eBar;
    TextMeshProUGUI eText;
    Slider hpBar;
    TextMeshProUGUI hpText;

    List<Skill> skills = new List<Skill>();
    [SerializeField] List<Button> skillButtons = new List<Button>();

    void Start()
    {
        SetStatus(5, 10, 80, 5f, 100f);

        SetUI();

        AddSkill();
    }

    void Update()
    {
        WriteUI();

        SetButtonActive();
    }

    private void SetUI()
    {
        hpBar = uiPoint.transform.GetChild(0).GetComponent<Slider>();
        hpText = uiPoint.transform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>();
        eBar = uiPoint.transform.GetChild(1).GetComponent<Slider>();
        eText = uiPoint.transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>();

        uiPoint.SetActive(true);
    }

    private void WriteUI()
    {
        hpBar.value = (float)currentHp / (float)maxHp;
        hpText.text = $"{currentHp}/{maxHp}";
        eBar.value = currentE / maxE;
        eText.text = $"{(int)currentE}/{(int)maxE}";
    }

    private void AddSkill()
    {
        var tempSkill = new Bishop_heal(this);
        skills.Add(tempSkill);
        skillButtons[0].onClick.AddListener(tempSkill.Act);
    }

    private void SetButtonActive()
    {
        for (int i = 0; i < skills.Count; i++)
        {
            if (currentE < skills[i].useE)
            {
                skillButtons[i].interactable = false;
            }
            else
            {
                skillButtons[i].interactable = true;
            }
        }
    }
}
