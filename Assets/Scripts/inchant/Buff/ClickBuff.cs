using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBuff : MonoBehaviour
{
    public string type;
    public float duration;
    public Sprite icon;

    public string inputKey = "";

    private void Update()
    {
        if (Input.GetKeyDown(inputKey))
        {
            Click();
        }
    }
    public void Click()
    {
        BuffMgr.instance.CreateBuff(type, duration, icon);
    }
}
