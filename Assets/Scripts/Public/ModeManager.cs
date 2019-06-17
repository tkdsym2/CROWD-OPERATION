using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public bool delayMode;
    public float delayTime;
    public int dummyNum;

    // before Start()
    private void Awake()
    {
        delayMode = false;
        delayTime = 0.0f;
        dummyNum = 12;
    }
}
