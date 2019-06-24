using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayTimeSlider : MonoBehaviour
{
    private Slider delaySlider;
    public GameObject statusManager;
    private StatusManager sm;
    private float delayTime;
    // Start is called before the first frame update
    void Start()
    {
        delaySlider = GetComponent<Slider>();
        sm = statusManager.GetComponent<StatusManager>();
        delayTime = sm.delayTime;
        delaySlider.value = delayTime;
    }

    // Update is called once per frame
    void Update(){}

    public void OnValueChange()
    {
        sm.delayTime = delaySlider.value / 1000f;
    }
}
