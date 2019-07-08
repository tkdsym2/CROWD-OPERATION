using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StudyManager : MonoBehaviour
{
    // for moving user cursor and dummy cursor params
    public bool isDelay;
    public bool isDiscover;
    public float delayTime;
    public int dummyNum;
    public float cdr;
    public int minAngle;
    public int maxAngle;
    public float discoveredTime;
    // for only experiments mode params
    public string subjectName;
    public bool isStartStudy;
    public bool finishInterval;
    public float sessionIntervalTime;
    public int selectedVisual;
    public List<string> studySessions;
    public string perSession;
    public bool isStartSession;
    public int resultState;// 0: success(correct self cursor), 1: error(not correct self cursor), 2: failed(time over)
    private ExperimentalManager em;
    public void Awake()
    {
        minAngle = 30;
        maxAngle = 360-minAngle;
        subjectName = "your name";
        isStartStudy = false;
        finishInterval = false;
        isDiscover = false;
        sessionIntervalTime = 4.0f;
        selectedVisual = 0;
        perSession = "";
        isStartSession = false;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    // Start is called before the first frame update
    void Start()
    {
        initializeSettings();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
    {
        initializeSettings();
    }
    
    private void initializeSettings()
    {
        em = GameObject.Find("ExperimentalManager").GetComponent<ExperimentalManager>();
        studySessions = new List<string>(em.ExperimentalSettings);
    }
}
