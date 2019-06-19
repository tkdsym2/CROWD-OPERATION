using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoveFunction;

public class DummyCursorMove : MonoBehaviour
{
    public StatusManager statusManager;
    private float delayTime, cdr;
    private float rx, ry;
    public Vector3 clone;
    public int hoge = 0;
    // Start is called before the first frame update
    void Start()
    {
        statusManager = GameObject.Find("StatusManager").GetComponent<StatusManager>();
        delayTime = statusManager.delayTime;
        cdr = statusManager.cdr;
    }

    // Update is called once per frame
    void Update()
    {
        float ax = Input.GetAxis("Mouse X");
        float ay = Input.GetAxis("Mouse Y");
        Vector3 direction = new Vector3(ax,ay, 0);
        StartCoroutine(DummyCursorFunc.DelayCursor(delayTime, () =>
            {
                DummyCursorFunc.MoveDummyCursor(gameObject, direction, cdr);
                clone = gameObject.transform.position;
            }));

    }
}
