using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slime : Character
{
    [SerializeField] GameObject uiPoint;

    TextMeshProUGUI skillName;
    Slider eBar;
    TextMeshProUGUI eText;
    Slider hpBar;
    TextMeshProUGUI hpText;

    List<Skill> skills = new List<Skill>();
    Skill loadedSkill = null;

    void Start()
    {
        SetStatus(10, 5, 50, 1.0f, 5.0f);

        SetUI();

        AddSkill();

        BattleStart();

        StartCoroutine(SkillAct());
    }

    void Update()
    {
        WriteUI();
        DieCheck();
    }

    private void SetUI()
    {
        skillName = uiPoint.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        eBar = uiPoint.transform.GetChild(1).GetComponent<Slider>();
        eText = uiPoint.transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>();
        hpBar = uiPoint.transform.GetChild(2).GetComponent<Slider>();
        hpText = uiPoint.transform.GetChild(2).GetComponentInChildren<TextMeshProUGUI>();

        uiPoint.SetActive(true);
    }

    private void WriteUI()
    {
        eBar.value = currentE / maxE;
        eText.text = $"{maxE - currentE, 0:0.0}s";
        hpBar.value = (float)currentHp / (float)maxHp;
        hpText.text = $"{currentHp}/{maxHp}";
    }

    private void SkillLoad()
    {
        loadedSkill = skills[Random.Range(0, skills.Count)];
        skillName.text = loadedSkill.skillName;
        maxE = loadedSkill.useE;
    }

    private void AddSkill()
    {
        skills.Add(new Slime_BodyAttack(this));
    }

    private void DieCheck()
    {
        if (currentHp <= 0)
        {
            isDead = true;
            uiPoint.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    IEnumerator SkillAct()
    {
        while (true)
        {
            if (loadedSkill == null)
            {
                SkillLoad();
            }

            if (currentE / maxE >= 1.0f)
            {
                loadedSkill.Act();
                loadedSkill = null;
            }


            if (currentHp <= 0)
            {
                yield break;
            }

            yield return null;
        }
    }
}
