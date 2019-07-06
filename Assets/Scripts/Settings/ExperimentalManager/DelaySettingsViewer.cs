using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelaySettingsViewer : MonoBehaviour
{
    public GameObject experimentalManager;
    private ExperimentalManager em;
    private Text delaySettings;
    // Start is calle  d before the first frame update
    void Start()
    {
        em = experimentalManager.GetComponent<ExperimentalManager>();
        delaySettings = gameObject.GetComponent<Text>();
        delaySettings.text = GenerateText(em.minDelay, em.maxDelay, em.intervalDelay, em.delaySession.Count);
    }

    // Update is called once per frame
    void Update()
    {
        delaySettings.text = GenerateText(em.minDelay, em.maxDelay, em.intervalDelay, em.delaySession.Count);
    }

    private string GenerateText(float _min, float _max, float _interval, int _count)
    {
        string minText = $"\n minDelay: {(_min * 1000).ToString()}";
        string maxText = $"\n maxDelay: {(_max * 1000).ToString()}";
        string intervalText = $"\n interval Delay: {(_interval * 1000).ToString()}";
        // string countText = $"\n all delay session: {_count.ToString()}";

        return "Current Settings: " + minText + maxText + intervalText;
    }
}
