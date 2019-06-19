using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CDRSlider : MonoBehaviour
{
    private Slider cdrSlider;
    public GameObject statusManager;
    private StatusManager sm;
    // Start is called before the first frame update
    void Start()
    {
        cdrSlider = GetComponent<Slider>();
        sm = statusManager.GetComponent<StatusManager>();
        cdrSlider.value = sm.cdr;
    }

    // Update is called once per frame
    void Update(){}

    public void OnValueChange()
    {
        sm.cdr = cdrSlider.value;
    }
}
