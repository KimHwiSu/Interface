using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;
    public List<BaseBuff> onbuff = new List<BaseBuff>();
    public float a = 1;

    private void Start()
    {
        instance = this;
    }


    public void BuffChange(string type)
    {
        if (onbuff.Count > 0)
        {
            for (int i = 0; i < onbuff.Count; ++i)
            {
                if (onbuff[i].type.Equals(type))
                {
                    Debug.Log(type);
                }
            }
        }
        else
        {
            Debug.Log("BuffOff");
        }
    }

    public void ChooseBuff(string type)
    {
        switch (type)
        {
            case "Atk":
                BuffChange(type);
                break;
            case "Def":
                BuffChange(type);
                break;
        }
    }
}
