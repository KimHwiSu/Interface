using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillFadeOut : MonoBehaviour
{
    public Image image;     // 스킬 이미지
    public Color zero;
    public Color img;
    public Color curCol;
    public bool SkillOn;
    public string WhatSkill;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        zero.a = 0;
        img = image.color;
        image.color = zero;
        curCol = img;
    }


    

    // Update is called once per frame
    void Update()
    {
        SkillOn = GameObject.Find(WhatSkill).GetComponent<SkillBtn>().fadeout;
        if (SkillOn)
        {
            Color color = curCol;
            image.color = color;
            if (color.a > 0)
            {
                color.a -= Time.deltaTime;
                curCol = color;
            }
            else
            {
                curCol = img;
                GameObject.Find(WhatSkill).GetComponent<SkillBtn>().fadeout = false;
            }
        }
    }
}
