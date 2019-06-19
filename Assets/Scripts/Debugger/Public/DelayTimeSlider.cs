using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayTimeSlider : MonoBehaviour
{
    private Slider delaySlider;
    private ModeManager modeManager;

    // Start is called before the first frame update
    void Start()
    {
        modeManager = GetComponent<ModeManager>();
        delaySlider = GetComponent<Slider>();
        delaySlider.value = modeManager.delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        // delaySlider.value = modeManager.delayTime;
    }

    public void ValueChangeCheck()
    {
        modeManager.delayTime = delaySlider.value / 1000f;
    }

    public void OnValueChange()
    {
        modeManager.delayTime = delaySlider.value / 1000f;
        Debug.Log(modeManager.delayTime);
    }
}
