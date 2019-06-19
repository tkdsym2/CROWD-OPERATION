using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentDelayTime : MonoBehaviour
{
    private Text currentDelayTime;
    public GameObject statusManager;
    private StatusManager sm;
    // Start is called before the first frame update
    void Start()
    {
        currentDelayTime = GetComponent<Text>();
        sm = statusManager.GetComponent<StatusManager>();
        currentDelayTime.text = sm.delayTime.ToString() + "\n" + sm.dummyNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentDelayTime.text = (sm.delayTime * 1000).ToString() + " [ms]\n" 
            + sm.dummyNum.ToString();
    }
}
