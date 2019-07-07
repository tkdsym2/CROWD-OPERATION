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
    public List<string> ExperimentalSettings;
    public int trial;

    void Awake()
    {
        dummyNumSession = new List<int>();
        dummyNumSession.Add(1);
        minDelay = 0.0f;
        maxDelay = 1.0f;
        intervalDelay = 0.05f;
        minAngle = 30;
        maxAngle = 360-minAngle;
        selectedVisual = 0;
        cdr = 1.0f;
        cdrSession = new List<float>();
        cdrSession.Add(cdr);
        delaySession = new List<int>();
        delaySession.Add(1);
        ExperimentalSettings = new List<string>();
        ExperimentalSettings.Add("init");
        trial = 5;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            SaveSeaquence();
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Experiments", LoadSceneMode.Single);
    }

    private int CalcDelaySession(float _min, float _max, float _interval)
    {
        delaySession.Clear();
        int min = (int)(_min * 1000);
        int max = (int)(_max * 1000);
        int interval = (int)(_interval * 1000);

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
        for(int i = 0; i < dummyNumSession.Count; i++){
            for(int j = 0; j < delaySessionSum; j++){
                for(int k = 0; k < cdrSession.Count; k++){
                    int _dummies = dummyNumSession[i];
                    int _delay = delaySession[j];
                    float _cdr = cdrSession[k];
                    int trial = 5;
                    ExperimentalSettings.Add($"{_dummies.ToString()}" + "," + $"{_delay.ToString()}" + "," + $"{_cdr.ToString()}" + "," + trial.ToString());
                    for(int l = 0; l < trial; l++){
                }
            }
        }
    }
}
