using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MoveFunction;
using UnityEngine.UI;

public class ExCursorMove : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private float rx, ry, ax, ay;
    private Vector3 ConvertPosition;
    private float delayTime, cdr;
    private float cx, cy;
    private float px, py;

    public Text judgeAndTimeView;
    private JudgeAndTimeViewer jatv;
    public Canvas timerPanel;
    private IntervalTimerViewController itvc;
    public Text intervalTimer;
    private IntervalTimer it;

    public Canvas trialPanel;
    private ControlTrialPanel ctp;
    public Text timerView;
    private TimerView tv;

    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        jatv = judgeAndTimeView.GetComponent<JudgeAndTimeViewer>();
        itvc = timerPanel.GetComponent<IntervalTimerViewController>();
        it = intervalTimer.GetComponent<IntervalTimer>();
        ctp = trialPanel.GetComponent<ControlTrialPanel>();
        tv = timerView.GetComponent<TimerView>();
        cx = Screen.width/2;
        cy = Screen.height/2;
    }

    // Update is called once per frame
    void Update()
    {
        if(sm.isStartSession)
        {
            ax = Input.GetAxis("Mouse X");
            ay = Input.GetAxis("Mouse Y");
            Vector3 direction = new Vector3(ax, ay, 0) * 0.5f;

            if(sm.isDelay) {
                StartCoroutine(UserCursorFunc.DelayCursor(sm.delayTime, () =>
                    {
                        UserCursorFunc.MoveCursor(gameObject, direction, sm.cdr);
                    }));
            } else {
                UserCursorFunc.MoveCursor(gameObject, direction, sm.cdr);
            }

            sm.absPosStock.Add(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y));
            sm.relPosStock.Add(new Vector2(gameObject.transform.position.x - px, gameObject.transform.position.y - py));
            px = gameObject.transform.position.x;
            py = gameObject.transform.position.y;
            

            if (gameObject.transform.position.y >= 4.6f && sm.isStartStudy) FinishSession();
        }
    }

    public void RandomizeCursorPos() {
        rx = UnityEngine.Random.Range(-9.0f, 9.0f);
        ry = UnityEngine.Random.Range(-4.5f, -5.0f);
        Vector3 screenPos = Camera.main.WorldToScreenPoint(new Vector3(rx, ry, 0));
        sm.initx = screenPos.x;
        sm.inity = screenPos.y;
        px = rx;
        py = ry;
        sm.absPosStock.Clear();
        sm.relPosStock.Clear();
        gameObject.transform.position = new Vector3(rx, ry, 0);
    }

    public void FinishSession()
    {
        if(gameObject.transform.position.y <= 4.5f)
        {
            sm.resultState = 1;
        } else {
            sm.resultState = 0;
        }
        ctp.HideTrialPanel();
        tv.ResetTimer();
        jatv.FinishRecording();
        itvc.ShowIntervalTimer();
        sm.HP = 100;
        sm.isStartSession = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        sm.HP = sm.HP - 20;
        if(sm.HP == 0)
        {
            FinishSession();
        }
    }
}
