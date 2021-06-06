using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffMgr : MonoBehaviour
{
    public static BuffMgr instance;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public GameObject BuffPrefab;

    public void CreateBuff(string type, float du, Sprite icon)
    {
        GameObject go = Instantiate(BuffPrefab, transform);
        go.GetComponent<UnityEngine.UI.Image>().sprite = icon;
        go.GetComponent<baseBuff>().init(type, du);
    }
}
