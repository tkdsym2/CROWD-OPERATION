using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MoveFunction;

public class ExCursorMove : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;


    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
