using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorVisualSetting : MonoBehaviour
{
    public GameObject demoManager;
    private DemoManager dm;
    private Dropdown visualSelector;
    // Start is called before the first frame update
    void Start()
    {
        dm = demoManager.GetComponent<DemoManager>();
        visualSelector = GetComponent<Dropdown>();
        visualSelector.value = dm.selectedVisual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeValue()
    {
        switch(visualSelector.value)
        {
            case 0:
                dm.selectedVisual = 0;
                break;
            case 1:
                dm.selectedVisual = 1;
                break;
            case 2:
                dm.selectedVisual = 2;
                break;
            default:
                break;
        }
    }
}
