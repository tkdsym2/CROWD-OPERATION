using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * this manager has all status of applications
 */

public class StatusManager : MonoBehaviour
{
    public float delayTime;// delay time forall cursor
    public int dummyNum;// number of dummy cursor
    public float cdr; // control-display ratio
    public void Awake() {
        delayTime = 0.0f;
        dummyNum = 12;
        cdr = 1.0f;
    }
}
