using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscoveredTime : MonoBehaviour
{
    public GameObject statusManager;
    private StatusManager sm;
    private Text timerText;
    private float startTime, finishTime, discoveredTime;
    // Start is called before the first frame update
    void Start()
    {
        sm = statusManager.GetComponent<StatusManager>();
        timerText = GetComponent<Text>();
        timerText.text = "Press 'r' key to start!" + "\n" + 
            "When you find your cursor, press 'SPACE' key!";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")) {
            startTime = Time.time;
            timerText.text = "";
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            discoveredTime = Time.time - startTime;
            timerText.text = discoveredTime.ToString("F2") + "[s]"; // when showed player, unit is second
            sm.discoveredTime = (discoveredTime * 1000); // when stored StatusManager, unit is ms
        }
    }
}
