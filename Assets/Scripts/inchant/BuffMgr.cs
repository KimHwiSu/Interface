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
    public GameObject buffPrefab;

    public void CreateBuff(string type, float dur, Sprite icon)
    {
        GameObject go = Instantiate(buffPrefab, transform);
        go.GetComponent<BaseBuff>().init(type, dur);
        go.GetComponent<UnityEngine.UI.Image>().sprite = icon;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
