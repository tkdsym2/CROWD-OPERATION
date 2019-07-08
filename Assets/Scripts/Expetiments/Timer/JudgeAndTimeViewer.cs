using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeAndTimeViewer : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private Text judgeAndTimerText;
    private float startTime, discoveredTime;
    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        judgeAndTimerText = gameObject.GetComponent<Text>();
        discoveredTime = 0.0f;
        judgeAndTimerText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartRecording()
    {
        startTime = Time.time;
    }

    public void FinishRecording()
    {
        discoveredTime = Time.time - startTime;
        sm.discoveredTime = (discoveredTime * 1000);
        judgeAndTimerText.text = sm.discoveredTime.ToString("F2") + "[ms]";
        sm.isStartSession = !sm.isStartSession;
        sm.finishInterval = false;
    }
}
