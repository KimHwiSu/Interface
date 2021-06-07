using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDeBuff : MonoBehaviour
{
    public string type;
    public float duration;
    public Sprite icon;

    public AudioClip clip;
    AudioSource sound;

    public string inputKey = "";

    private void Update()
    {
        if (Input.GetKeyDown(inputKey))
        {
            Click();
            sound = SoundMgr.instance.SFXPlay("DeBuff", clip);
        }

        if (DeBuffData.instance.onDebuff.Count > 0)
        {
            if (!sound.isPlaying)
            {
                sound = SoundMgr.instance.SFXPlay("DeBuff", clip);
            }
        }
        else
        {
            if (sound)
            {
                if (sound.isPlaying)
                {
                    sound.Stop();
                }
            }
        }

     
    }
    public void Click()
    {
        DeBuffMgr.instance.CreateDeBuff(type, duration, icon);
    }
}
