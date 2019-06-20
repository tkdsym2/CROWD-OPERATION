using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HelpText : MonoBehaviour
{
    private Text helpText;
    private Color textColor;
    private float nonMoveTime, stopCursor;
    // Start is called before the first frame update
    void Start()
    {
        helpText = GetComponent<Text>();
        textColor = helpText.material.GetColor("_Color");
        textColor.a = 0;
        helpText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float ax = Input.GetAxis("Mouse X");
        float ay = Input.GetAxis("Mouse Y");
        float movement = Mathf.Abs(ax) + Mathf.Abs(ay);

        if(movement == 0){
            textColor.a = 0;
            helpText.enabled = true;
            StartCoroutine(DelayAction(2.0f, () => {
                textColor.a = textColor.a + 0.1f;
                if(textColor.a > 1) textColor.a = 1;
                helpText.material.SetColor("_Color", textColor);
            }));
        } else {
            helpText.enabled = false;
            textColor.a = 0;
        }
    }

    private IEnumerator DelayAction(float waitTime, Action action)
{
    yield return new WaitForSeconds(waitTime);
    action();
}
}
