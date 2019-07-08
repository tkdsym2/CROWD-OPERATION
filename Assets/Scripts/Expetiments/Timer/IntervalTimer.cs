using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntervalTimer : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private Text timerView;
    private float intervalTime;
    private int seconds;
    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        timerView = gameObject.GetComponent<Text>();
        intervalTime = sm.sessionIntervalTime;// interval is 3 seconds
    }

    // Update is called once per frame
    void Update()
    {
        if(sm.isStartStudy && sm.finishInterval == false){
            intervalTime -= Time.deltaTime;
            seconds = (int)intervalTime;
            timerView.text = seconds.ToString();
            if(seconds <= 0){
                sm.sessionIntervalTime = 4.0f;
                sm.finishInterval = true;
                return;
            }
        }
    }
}
