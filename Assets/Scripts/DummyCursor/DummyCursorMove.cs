using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoveFunction;

public class DummyCursorMove : MonoBehaviour
{
    private ModeManager modeManager;
    private float rx, ry;

    // Start is called before the first frame update
    void Start()
    {
        modeManager = GetComponent<ModeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float ax = Input.GetAxis("Mouse X");
        float ay = Input.GetAxis("Mouse Y");
        Vector3 direction = new Vector3(ax,ay, 0);
        if (modeManager.delayMode)
        {
            StartCoroutine(UserCursorFunc.DelayCursor(modeManager.delayTime, () =>
            {
                DummyCursorFunc.MoveDummyCursor(gameObject, direction);
            }));
        }
        else
        {
            DummyCursorFunc.MoveDummyCursor(gameObject, direction);
        }
    }
}
