using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayTimeField : MonoBehaviour
{
    private InputField inputField;
    private ModeManager modeManager;
    // Start is called before the first frame update
    void Start()
    {
        modeManager = GetComponent<ModeManager>();
        inputField = this.GetComponent<InputField>();
        inputField.text = modeManager.delayTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
