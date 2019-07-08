using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MoveFunction;

public class ExCursorMove : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private float rx, ry, ax, ay;
    private Vector3 ConvertPosition;
    private float delayTime, cdr;

    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sm.isStartSession)
        {
            ax = Input.GetAxis("Mouse X");
            ay = Input.GetAxis("Mouse Y");
            Vector3 direction = new Vector3(ax, ay, 0) * 0.5f;

            if(!sm.isDelay) {
                StartCoroutine(UserCursorFunc.DelayCursor(sm.delayTime, () =>
                    {
                        UserCursorFunc.MoveCursor(gameObject, direction, sm.cdr);
                    }));
            } else {
                UserCursorFunc.MoveCursor(gameObject, direction, sm.cdr);
            }
        }
    }

    public void RandomizeCursorPos() {
        rx = UnityEngine.Random.Range(-9.0f, 9.0f);
        ry = UnityEngine.Random.Range(-5.0f, 5.0f);
        gameObject.transform.position = new Vector3(rx, ry, 0);
    }
}
