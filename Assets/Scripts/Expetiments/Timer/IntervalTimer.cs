using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntervalTimer : MonoBehaviour
{
    private StudyManager sm;
    private Text timerView;
    private float intervalTime;
    private int seconds;
    public GameObject userCursor;
    private ExCursorMove excv;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StudyManager").GetComponent<StudyManager>();
        excv = userCursor.GetComponent<ExCursorMove>();
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
                SetStudyParams();
                sm.isStartSession = !sm.isStartSession;
                return;
            }
        }
    }

    private void SetStudyParams()
    {
        int sessionCount = sm.studySessions.Count;
        int sessionNum = UnityEngine.Random.Range(0, sessionCount);
        sm.perSession = sm.studySessions[sessionNum];
        sm.studySessions.RemoveAt(sessionNum);

        string[] _params = sm.perSession.Split(',');
        sm.dummyNum = int.Parse(_params[0]);
        sm.delayTime = float.Parse(_params[1]) / 1000f;
        sm.isDelay = (sm.delayTime) == 0f ? true : false;
        sm.cdr = float.Parse(_params[2]);

        excv.RandomizeCursorPos();// generate user cursor
    }
}
