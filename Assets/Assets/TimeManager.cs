using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txt_customTime;
    float customTime;
    bool isCounting;

    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
        isCounting = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R)) 
        {
            isCounting = true;
        }
        if (isCounting) 
        {
            customTime += Time.deltaTime;
        }
        txt_customTime.text = Mathf.Floor(customTime).ToString();
    }
}
