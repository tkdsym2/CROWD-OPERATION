using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiscoveredTime : MonoBehaviour
{
    public GameObject statusManager;
    private StatusManager sm;
    private Text timerText;
    private float startTime, discoveredTime;
    // Start is called before the first frame update
    void Start()
    {
        sm = statusManager.GetComponent<StatusManager>();
        timerText = GetComponent<Text>();
        discoveredTime = 0.0f;
        timerText.text = "Press <size=25><color=#4286f4>'R'</color></size> key to start!" + "\n" + "\n" +
            "When you find your cursor, press <size=25><color=#4286f4>'SPACE'</color></size> key!" + "\n" + "\n" +
            "also, press <size=25><color=#4286f4>'D'</color></size> key to open debugger!";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")) {
            sm.isStarted = !sm.isStarted;
            sm.canRandomize = !sm.canRandomize;
            startTime = Time.time;
            timerText.text = "";
        }

        if(Input.GetKeyDown(KeyCode.Space) && sm.isStarted){
            discoveredTime = Time.time - startTime;
            timerText.text = discoveredTime.ToString("F2") + "[s]" + "\n"
                + "Press <size=25><color=#4286f4>'R'</color></size> key to try again!" + "\n" + "\n" +
                "Press <size=25><color=#4286f4>'D'</color></size> key to open debugger!"; // when showed player, unit is second
            sm.discoveredTime = (discoveredTime * 1000); // when stored StatusManager, unit is ms
            sm.isStarted = !sm.isStarted;
            sm.canRandomize = !sm.canRandomize;
        }
    }
}
