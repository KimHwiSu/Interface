using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffData : MonoBehaviour
{
    public static BuffData instance;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    public List<baseBuff> onbuff = new List<baseBuff>();

    public void BuffChange()
    {
        if (onbuff.Count > 0)
        {
            Debug.Log("BuffOn");
        }
        else
        {
            Debug.Log("BuffOff");
        }
    }
}
