using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CDRSetting : MonoBehaviour
{
    private Slider cdrSlider;
    public GameObject demoManager;
    private DemoManager dm;
    // Start is called before the first frame update
    void Start()
    {
        cdrSlider = GetComponent<Slider>();
        dm = demoManager.GetComponent<DemoManager>();
        cdrSlider.value = dm.cdr;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeValue()
    {
        dm.cdr = cdrSlider.value;
    }
}
