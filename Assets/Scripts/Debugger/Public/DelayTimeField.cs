using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayTimeField : MonoBehaviour
{
    public InputField inputField;
    private ModeManager modeManager;
    // Start is called before the first frame update
    void Start()
    {
        modeManager = GetComponent<ModeManager>();
        inputField = this.GetComponent<InputField>();
        inputField.text = modeManager.delayTime.ToString();
        inputField.onValueChanged.AddListener(delegate { ValueChangedCheck(); });
    }

    // Update is called once per frame
    void Update()
    {
        inputField.text = modeManager.delayTime.ToString();
    }

    public void ValueChangedCheck()
    {
        modeManager.delayTime = float.Parse(inputField.text) / 1000f;
    }
}
