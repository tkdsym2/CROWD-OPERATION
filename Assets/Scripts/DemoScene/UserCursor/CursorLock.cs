using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    private bool isLock = false;
    private bool isVisible = false;
    void Awake(){
        Application.targetFrameRate = 60; 
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = isVisible;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l") || Input.GetKeyDown("r")) isLock = false;
        if (Input.GetKeyDown("v")) isVisible = !isVisible;
        if (Input.GetKeyDown("r")) isLock = true;

        if (isLock)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
