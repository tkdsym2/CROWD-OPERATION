using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentSettingsViewer : MonoBehaviour
{
    private Text currentSettings;
    public GameObject demoManager;
    private DemoManager dm;
    // Start is called before the first frame update
    void Start()
    {
        currentSettings = GetComponent<Text>();
        dm = demoManager.GetComponent<DemoManager>();
        currentSettings.text = "\n" + "\n"
             + (dm.delayTime * 1000).ToString() + "[ms]\n"
             + dm.dummyNum.ToString() + "\n"
             + dm.cdr.ToString() + "\n"
             + dm.minAngle.ToString() + " / " + dm.maxAngle.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        currentSettings.text = "\n" + "\n"
             + (dm.delayTime * 1000).ToString() + "[ms]\n"
             + dm.dummyNum.ToString() + "\n"
             + dm.cdr.ToString() + "\n"
             + dm.minAngle.ToString() + " / " + dm.maxAngle.ToString();
    }
}
