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

    public Text judgeAndTimeView;
    private JudgeAndTimeViewer jatv;
    public Canvas timerPanel;
    private IntervalTimerViewController itvc;
    public Text intervalTimer;
    private IntervalTimer it;

    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        jatv = judgeAndTimeView.GetComponent<JudgeAndTimeViewer>();
        itvc = timerPanel.GetComponent<IntervalTimerViewController>();
        it = intervalTimer.GetComponent<IntervalTimer>();
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

            if (Input.GetKeyDown(KeyCode.Space) && sm.isStartStudy)
            {
                jatv.FinishRecording();
                itvc.ShowIntervalTimer();
                sm.isStartSession = false;
            }
        }
    }

    public void RandomizeCursorPos() {
        rx = UnityEngine.Random.Range(-9.0f, 9.0f);
        ry = UnityEngine.Random.Range(-5.0f, 5.0f);
        gameObject.transform.position = new Vector3(rx, ry, 0);
    }
}
