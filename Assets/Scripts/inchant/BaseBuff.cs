using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseBuff : MonoBehaviour
{
    public string type;
    public float duration;
    public float currtime;
    public Image icon; 
    // Start is called before the first frame update
    private void Awake()
    {
        icon = GetComponent<Image>();
    }

    public void init(string type, float dur)
    {
        this.type = type;
        duration = dur;
        currtime = duration;
        icon.fillAmount = 1;

        Execute();
    }

    WaitForSeconds seconds = new WaitForSeconds(0.1f);
    public void Execute()
    {
        Debug.Log(PlayerData.instance.a);
        PlayerData.instance.onbuff.Add(this);
        PlayerData.instance.ChooseBuff(type);
        StartCoroutine(Active());
    }

    
    IEnumerator Active()
    {
        while (currtime > 0)
        {
            currtime -= 0.1f;
            icon.fillAmount = currtime / duration;
            yield return seconds;
        }
        icon.fillAmount = 0;
        currtime = 0;
        DeActive();
    }

    public void DeActive()
    {
        PlayerData.instance.onbuff.Remove(this);
        PlayerData.instance.ChooseBuff(type);
        Destroy(gameObject);
    }
}
