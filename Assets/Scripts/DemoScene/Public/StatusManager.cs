using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * this manager has all status of applications
 */

public class StatusManager : MonoBehaviour
{
    public bool isDelay;// wherger to switch delay mode
    public bool isDiscover;// whetherto be discovered self cursor
    public float delayTime;// from demo manager
    public int dummyNum;// from demo manager
    public float cdr;// from demo manager
    public bool isShowingDebugger; // debugger view switch
    public int minAngle; // from demo manager
    public int maxAngle;// from demo manager
    public float discoveredTime;// until discovered time[ms]
    public bool isStarted;// whether to be started recording
    public bool canRandomize;// whether to randomize cursor
    public int selectedVisual;// from demo manager
    private DemoManager dm;
    public void Awake() {
        isDiscover = false;
        isShowingDebugger = false;
        discoveredTime = 0.0f;
        isStarted = false;
        canRandomize = false;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Start(){
        initializeSettings();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Update(){
        if(Input.GetKeyDown("d")){
            SceneManager.LoadScene("Settings");
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
    {
        initializeSettings();
    }

    private void initializeSettings()
    {
        dm = GameObject.Find("DemoManager").GetComponent<DemoManager>();
        delayTime = dm.delayTime;
        dummyNum = dm.dummyNum;
        cdr = dm.cdr;
        minAngle = dm.minAngle;
        maxAngle = dm.maxAngle;
        selectedVisual = dm.selectedVisual;
        isDelay = (dm.delayTime) == 0 ? true : false;
    }
}
