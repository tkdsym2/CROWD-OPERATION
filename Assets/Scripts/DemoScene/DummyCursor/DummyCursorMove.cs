using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoveFunction;

public class DummyCursorMove : MonoBehaviour
{
    public StatusManager sm;
    private float rx, ry;
    public Vector3 clone;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StatusManager").GetComponent<StatusManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float ax = Input.GetAxis("Mouse X");
        float ay = Input.GetAxis("Mouse Y");
        Vector3 direction = new Vector3(ax,ay, 0) * 0.5f;

        if(!sm.isDelay){
            StartCoroutine(DummyCursorFunc.DelayCursor(sm.delayTime, () =>
            {
                DummyCursorFunc.MoveDummyCursor(gameObject, direction, sm.cdr);
                clone = gameObject.transform.position;
            }));
        } else {
            DummyCursorFunc.MoveDummyCursor(gameObject, direction, sm.cdr);
                clone = gameObject.transform.position;
        }
    }
}
