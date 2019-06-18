using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public bool delayMode;
    public float delayTime;
    public int dummyNum;
    public float cdr;

    // before Start()
    private void Awake()
    {
        delayMode = false;
        delayTime = 0/1000f;
        dummyNum = 12;
        cdr = 1.0f;
    }
}
