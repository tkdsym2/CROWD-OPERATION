using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MoveFunction;

public class CursorMove : MonoBehaviour
{
    // cursor settings
    private ModeManager modeManager;

    // define init values
    float rx, ry;
    private Vector3 ConvertPosition;

    // Start is called before the first frame update
    void Start()
    {
        modeManager = GetComponent<ModeManager>();
        RandomizeCursorPos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) RandomizeCursorPos();
        if (Input.GetKeyDown("d"))
        {
            modeManager.delayMode = !modeManager.delayMode;
        }

        float ax = Input.GetAxis("Mouse X");
        float ay = Input.GetAxis("Mouse Y");

        Vector3 direction = new Vector3(ax, ay, 0);
        StartCoroutine(UserCursorFunc.DelayCursor(modeManager.delayTime, () =>
        {
            UserCursorFunc.MoveCursor(gameObject, direction, modeManager.cdr);
        }));
    }

    private void RandomizeCursorPos() {
        rx = UnityEngine.Random.Range(-9.0f, 9.0f);
        ry = UnityEngine.Random.Range(-5.0f, 5.0f);
        gameObject.transform.position = new Vector3(rx, ry, 0);
    }
}
