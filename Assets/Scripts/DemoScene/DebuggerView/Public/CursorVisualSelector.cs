using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorVisualSelector : MonoBehaviour
{
    public GameObject statusManager;
    private StatusManager sm;
    private Dropdown visualSelector;
    // Start is called before the first frame update
    void Start()
    {
        sm = statusManager.GetComponent<StatusManager>();
        visualSelector = GetComponent<Dropdown>();
        visualSelector.value = sm.selectedVisual;
    }

    // Update is called once per frame
    void Update(){}

    public void OnChangeValue()
    {
        switch(visualSelector.value)
        {
            case 0:
                sm.selectedVisual = 0;
                Debug.Log(sm.selectedVisual.ToString());
                break;
            case 1:
                sm.selectedVisual = 1;
                Debug.Log(sm.selectedVisual.ToString());
                break;
            case 2:
                sm.selectedVisual = 2;
                Debug.Log(sm.selectedVisual.ToString());
                break;
            default:
                break;
        }
    }
}
