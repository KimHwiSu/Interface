using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDeBuff : MonoBehaviour
{
    public string type;
    public float duration;
    public Sprite icon;

    public AudioClip clip;

    public string inputKey = "";

    private void Update()
    {
        if (Input.GetKeyDown(inputKey))
        {
            Click();

            SoundMgr.instance.SFXPlay("DeBuff", clip);
        }

     
    }
    public void Click()
    {
        DeBuffMgr.instance.CreateDeBuff(type, duration, icon);
    }
}
