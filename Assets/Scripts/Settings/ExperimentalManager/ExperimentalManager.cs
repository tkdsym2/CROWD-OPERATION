using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Data;

public class ExperimentalManager : MonoBehaviour
{
    public List<int> dummyNumSession;
    public float minDelay;
    public float maxDelay;
    public float intervalDelay;
    public int minAngle;
    public int maxAngle;
    public int selectedVisual;
    public List<int> delaySession;

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
        delaySession = new List<int>();
        delaySession.Add(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Experiments", LoadSceneMode.Single);
    }

    private int CalcSession(float _min, float _max, float _interval)
    {
        delaySession.Clear();
        int min = (int)(_min);
        int max = (int)(_max);
        int interval = (int)(_interval);

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
}
