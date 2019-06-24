using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmountSlider : MonoBehaviour
{
    private Slider amountSlider;
    public GameObject statusManager;
    private StatusManager sm;
    private int dummyNum;
    // Start is called before the first frame update
    void Start()
    {
        amountSlider = GetComponent<Slider>();
        sm = statusManager.GetComponent<StatusManager>();
        dummyNum = sm.dummyNum;
        amountSlider.value = dummyNum;
    }

    // Update is called once per frame
    void Update(){}

    public void OnValueChange()
    {
        sm.dummyNum = (int)amountSlider.value;
    }
}
