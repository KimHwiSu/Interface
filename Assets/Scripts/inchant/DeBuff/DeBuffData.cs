using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBuffData : MonoBehaviour
{
    public static DeBuffData instance;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    public List<baseDeBuff> onDebuff = new List<baseDeBuff>();

    public void DeBuffChange()
    {
        if (onDebuff.Count > 0)
        {
            Debug.Log("DeBuffOn");
        }
        else
        {
            Debug.Log("DeBuffOff");
        }
    }
}
