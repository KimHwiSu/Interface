using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public BTN curBtn;

    public void OnClickBtn()
    {
        switch (curBtn)
        {
            case BTN.Start:
                Debug.Log("Start");
                break;
            case BTN.Option:
                Debug.Log("Option");
                break;
            case BTN.Quit:
                Debug.Log("Quit");
                break;
        }
    }
}
