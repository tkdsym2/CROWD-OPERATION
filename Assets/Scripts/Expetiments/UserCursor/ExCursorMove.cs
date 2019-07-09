﻿using System.Collections;
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

            if (Input.GetKeyDown(KeyCode.Space) && sm.isStartStudy)
            {
                Vector3 currentCursorPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
                float dist = Vector2.Distance(new Vector2(cx, cy), new Vector2(currentCursorPos.x, currentCursorPos.y));
                if(dist <= 23f) {
                    sm.resultState = 0;
                } else {
                    sm.resultState = 1;
                }
                Debug.Log("distance from center: " + dist.ToString());
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