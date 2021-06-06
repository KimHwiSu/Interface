using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBuffMgr : MonoBehaviour
{
    public static DeBuffMgr instance;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public GameObject DeBuffPrefab;

    public void CreateDeBuff(string type, float du, Sprite icon)
    {
        GameObject go = Instantiate(DeBuffPrefab, transform);
        go.GetComponent<UnityEngine.UI.Image>().sprite = icon;
        go.GetComponent<baseDeBuff>().init(type, du);
    }
}
