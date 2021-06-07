using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBuff : MonoBehaviour
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
            
            SoundMgr.instance.SFXPlay("Buff", clip);
        }
    }
    public void Click()
    {
        BuffMgr.instance.CreateBuff(type, duration, icon);
    }
}
