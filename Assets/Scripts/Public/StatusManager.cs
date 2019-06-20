using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * this manager has all status of applications
 */

public class StatusManager : MonoBehaviour
{
    public bool isDiscover;// whether discovered self cursor
    public float delayTime;// delay time forall cursor[ms]
    public int dummyNum;// number of dummy cursor
    public float cdr; // control-display ratio
    public bool isShowingDebugger; // debugger view switch
    public int minRotation; // minimum rotation
    public int maxRotation;// maximum rotation
    public float discoveredTime;// until discovered time[ms]
    public bool isStarted;// whether started recording
    public bool canRandomize;
    public void Awake() {
        isDiscover = false;
        delayTime = 0.0f; // second
        dummyNum = 12;
        cdr = 1.0f;
        isShowingDebugger = false;
        minRotation = 30;
        maxRotation = 345;
        discoveredTime = 0.0f;
        isStarted = false;
        canRandomize = false;
    }
}
