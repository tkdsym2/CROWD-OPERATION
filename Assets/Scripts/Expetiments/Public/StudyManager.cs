using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StudyManager : MonoBehaviour
{
    public string subjectName;
    public bool isStartStudy;
    public bool finishInterval;
    public float sessionIntervalTime;
    public bool isDiscover;
    public int selectedVisual;
    private ExperimentalManager em;
    public void Awake()
    {
        subjectName = "your name";
        isStartStudy = false;
        finishInterval = false;
        isDiscover = false;
        sessionIntervalTime = 4.0f;
        selectedVisual = 0;
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
    }
}
