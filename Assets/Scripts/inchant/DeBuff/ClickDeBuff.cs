using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDeBuff : MonoBehaviour
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
        DeBuffMgr.instance.CreateDeBuff(type, duration, icon);
    }
}
