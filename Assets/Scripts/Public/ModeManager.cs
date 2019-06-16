using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public bool delayMode;
    public int delayTime;
    public int dummyNum;

    // before Start()
    private void Awake()
    {
        delayMode = false;
        delayTime = 0;
        dummyNum = 10;
    }
}
