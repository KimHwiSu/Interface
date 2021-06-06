using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBuff : MonoBehaviour
{
    public string type;
    public float dur;
    public Sprite icon;

    public void Click()
    {
        BuffMgr.instance.CreateBuff(type, dur, icon);
    }
}
