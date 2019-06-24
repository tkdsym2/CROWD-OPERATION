using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmountOfCursorSetting : MonoBehaviour
{
    private Slider amountSlider;
    public GameObject demoManager;
    private DemoManager dm;
    private int dummyNum;
    // Start is called before the first frame update
    void Start()
    {
        amountSlider = GetComponent<Slider>();
        dm = demoManager.GetComponent<DemoManager>();
        dummyNum = dm.dummyNum;
        amountSlider.value = dummyNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChange()
    {
        dm.dummyNum = (int)amountSlider.value;
    }
}
