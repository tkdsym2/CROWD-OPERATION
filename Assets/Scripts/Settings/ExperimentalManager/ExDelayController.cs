using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExDelayController : MonoBehaviour
{
    public GameObject experimentalManager;
    private ExperimentalManager em;
    public InputField maxDelayField, minDelayField, intervalDelayField;
    public Text maxDelayText, minDelayText, intervalDelayText;
    // Start is called before the first frame update
    void Start()
    {
        em = experimentalManager.GetComponent<ExperimentalManager>();
        maxDelayField = maxDelayField.GetComponent<InputField>();
        minDelayField = minDelayField.GetComponent<InputField>();
        intervalDelayField = intervalDelayField.GetComponent<InputField>();

        maxDelayText = maxDelayText.GetComponent<Text>();
        minDelayText = minDelayText.GetComponent<Text>();
        intervalDelayText = intervalDelayText.GetComponent<Text>();

        maxDelayField.text = (em.maxDelay*1000).ToString();
        minDelayField.text = (em.minDelay*1000).ToString();
        intervalDelayField.text = (em.intervalDelay*1000).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputMaxDelay()
    {
        maxDelayText.text = maxDelayField.text;
        float _temp = (maxDelayText.text == "" || maxDelayText.text == null) ? 1f : float.Parse(maxDelayText.text);
        em.maxDelay = _temp/1000f;
    }

    public void InputMinDelay()
    {
        minDelayText.text = minDelayField.text;
        float _temp = (minDelayText.text == "" || minDelayText.text == null) ? 1f : float.Parse(minDelayText.text);
        em.minDelay = _temp/1000f;
    }

    public void InputIntervalDelay()
    {
        intervalDelayText.text = intervalDelayField.text;
        float _temp = (intervalDelayText.text == "" || intervalDelayText.text == null) ? 1f : float.Parse(intervalDelayText.text);
        em.intervalDelay =_temp/1000f;
    }
}
