﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoveFunction;

public class ExDummyCursorMove : MonoBehaviour
{
    private StudyManager sm;
    private float rx, ry, ax, ay;
    public Vector3 clone;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StudyManager").GetComponent<StudyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ax = Input.GetAxis("Mouse X");
        ay = Input.GetAxis("Mouse Y");
        Vector3 direction = new Vector3(ax,ay, 0) * 0.5f;

        if(sm.isDelay){
            StartCoroutine(DummyCursorFunc.DelayCursor(sm.delayTime, () =>
            {
                DummyCursorFunc.MoveDummyCursor(gameObject, direction, sm.cdr, sm.algoPattern);
                clone = gameObject.transform.position;
            }));
        } else {
            DummyCursorFunc.MoveDummyCursor(gameObject, direction, sm.cdr, sm.algoPattern);
            clone = gameObject.transform.position;
        }
    }
}
