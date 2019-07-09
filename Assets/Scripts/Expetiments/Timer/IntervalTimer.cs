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
    public GameObject dummyCursor;
    private ExDummyCreator exdc;
    public Text judgeAndTimeView;
    private JudgeAndTimeViewer jatv;

    public Canvas timerPanel;
    private IntervalTimerViewController itvc;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StudyManager").GetComponent<StudyManager>();
        excv = userCursor.GetComponent<ExCursorMove>();
        exdc = dummyCursor.GetComponent<ExDummyCreator>();
        jatv = judgeAndTimeView.GetComponent<JudgeAndTimeViewer>();
        itvc = timerPanel.GetComponent<IntervalTimerViewController>();
        timerView = gameObject.GetComponent<Text>();
        intervalTime = sm.sessionIntervalTime;// interval is 3 seconds
    }

    // Update is called once per frame
    void Update()
    {
        if(sm.isStartStudy && !sm.isStartSession) StartCountdown();
    }

    public void StartCountdown()
    {
        intervalTime -= Time.deltaTime;
        seconds = (int)intervalTime;
        timerView.text = seconds.ToString();
        if(seconds <= 0){
            sm.isDiscover = false;
            intervalTime = sm.sessionIntervalTime;
            seconds = (int)intervalTime;
            sm.finishInterval = true;
            SetStudyParams();
            jatv.StartRecording();
            itvc.HideIntervalTimer();
            sm.isStartSession = !sm.isStartSession;
            return;
        }
    }

    private void SetStudyParams()
    {
        int sessionCount = sm.studySessions.Count;
        if(sessionCount == 0) Quit();
        int sessionNum = UnityEngine.Random.Range(0, sessionCount);
        sm.perSession = sm.studySessions[sessionNum];
        sm.studySessions.RemoveAt(sessionNum);

        string[] _params = sm.perSession.Split(',');
        sm.dummyNum = int.Parse(_params[0]);
        sm.delayTime = float.Parse(_params[1]) / 1000f;
        sm.isDelay = (sm.delayTime) == 0f ? false : true;
        sm.cdr = float.Parse(_params[2]);

        excv.RandomizeCursorPos();// generate user cursor
        if(sm.dummyNum > 1) exdc.GenerateDummyCursor(sm.dummyNum);// generate dummy curosr
    }

    void Quit() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
        #endif
    }
}
