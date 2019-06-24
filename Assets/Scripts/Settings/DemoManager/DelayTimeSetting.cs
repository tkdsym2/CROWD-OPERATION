using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayTimeSetting : MonoBehaviour
{
    private Slider delaySlider;
    public GameObject demoManager;
    private DemoManager dm;
    private float delayTime;
    // Start is called before the first frame update
    void Start()
    {
        delaySlider = GetComponent<Slider>();
        dm = demoManager.GetComponent<DemoManager>();
        delayTime = dm.delayTime;
        delaySlider.value = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChange()
    {
        dm.delayTime = delaySlider.value / 1000f;
    }
}
