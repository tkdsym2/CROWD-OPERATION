using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MoveFunction;

public class CursorMove : MonoBehaviour
{
    // refer application settings
    public GameObject statusManager;

    // define init values
    float rx, ry;
    private Vector3 ConvertPosition;
    private float delayTime, cdr;

    // Start is called before the first frame update
    void Start()
    {
        delayTime = statusManager.GetComponent<StatusManager>().delayTime;
        cdr = statusManager.GetComponent<StatusManager>().cdr;
        RandomizeCursorPos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) RandomizeCursorPos();

        float ax = Input.GetAxis("Mouse X");
        float ay = Input.GetAxis("Mouse Y");
        Vector3 direction = new Vector3(ax, ay, 0);

        StartCoroutine(UserCursorFunc.DelayCursor(delayTime, () =>
        {
            UserCursorFunc.MoveCursor(gameObject, direction, cdr);
        }));
    }

    private void RandomizeCursorPos() {
        rx = UnityEngine.Random.Range(-9.0f, 9.0f);
        ry = UnityEngine.Random.Range(-5.0f, 5.0f);
        gameObject.transform.position = new Vector3(rx, ry, 0);
    }
}
