using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;

public class ExperimentalManager : MonoBehaviour
{
    public List<int> dummyNumSession;
    public float minDelay;
    public float maxDelay;
    public float intervalDelay;
    public int minAngle;
    public int maxAngle;
    public float cdr;
    public List<float> cdrSession;
    public int selectedVisual;
    public List<int> delaySession;
    public List<int> algoPattern;
    public List<string> ExperimentalSettings;
    public int trial;

    void Awake()
    {
        dummyNumSession = new List<int>();
        dummyNumSession.Add(30);
        dummyNumSession.Add(50);
        dummyNumSession.Add(70);
        dummyNumSession.Add(90);
        dummyNumSession.Add(100);
        minDelay = 0.0f;
        maxDelay = 1.0f;
        intervalDelay = 0.05f;
        minAngle = 60;
        maxAngle = 360-minAngle;
        selectedVisual = 0;
        cdr = 1.0f;
        cdrSession = new List<float>();
        cdrSession.Add(cdr);
        cdrSession.Add(0.5f);
        cdrSession.Add(2.0f);
        delaySession = new List<int>();
        delaySession.Add(1);
        algoPattern = new List<int>();
        algoPattern.Add(0);// only x move
        algoPattern.Add(1);// only y move
        algoPattern.Add(2);// rotate angle pattern
        algoPattern.Add(3);// look to player

        ExperimentalSettings = new List<string>();
        ExperimentalSettings.Add("init");
        trial = 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene()
    {
        SaveSeaquence();
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Experiments", LoadSceneMode.Single);
    }

    private int CalcDelaySession(float _min, float _max, float _interval)
    {
        delaySession.Clear();
        int min = Mathf.CeilToInt(_min * 1000f);
        int max = Mathf.CeilToInt(_max * 1000f);
        int interval = Mathf.CeilToInt(_interval * 1000f);

        if(min >= max) return 0;

        if(interval == 0)
        {
            delaySession.Add(min);
            delaySession.Add(max);
            return delaySession.Count;
        }

        if((max-min) % interval == 0)
        {
            for(int i = min; i < (max-min)/interval; i++)
            {
                delaySession.Add(i*interval);
            }
            delaySession.Add(max);
            return delaySession.Count;
        } else
        {
            for(int i = min; i < (max-min)/interval; i++)
            {
                delaySession.Add(i*interval);
            }
            delaySession.Add(max);
            return delaySession.Count;
        }
    }

    public void SaveSeaquence()
    {
        ExperimentalSettings.Clear();
        int delaySessionSum = CalcDelaySession(minDelay, maxDelay, intervalDelay);
        for(int i = 0; i < trial; i++)
        {
            int _dummies = dummyNumSession[Random.Range(0, dummyNumSession.Count)];
            int _delay = delaySession[Random.Range(0, delaySession.Count)];
            float _cdr = cdrSession[Random.Range(0, cdrSession.Count)];
            int _algo = algoPattern[Random.Range(0, algoPattern.Count)];
            ExperimentalSettings.Add($"{_dummies.ToString()}" + "," + $"{_delay.ToString()}" + "," + $"{_cdr.ToString()}" + "," + $"{_algo.ToString()}");
        }
        // for(int i = 0; i < dummyNumSession.Count; i++){
        //     for(int j = 0; j < delaySessionSum; j++){
        //         for(int k = 0; k < cdrSession.Count; k++){
        //             for(int l = 0; l < trial; l++){
        //                 int _dummies = dummyNumSession[i];
        //                 int _delay = delaySession[j];
        //                 float _cdr = cdrSession[k];
        //                 ExperimentalSettings.Add($"{_dummies.ToString()}" + "," + $"{_delay.ToString()}" + "," + $"{_cdr.ToString()}");
        //             }
        //         }
        //     }
        // }
    }
}
