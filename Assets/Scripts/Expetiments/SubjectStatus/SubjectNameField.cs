using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubjectNameField : MonoBehaviour
{
    public InputField subjectNameField;
    public Text subjectName;
    // Start is called before the first frame update
    void Start()
    {
        subjectNameField = subjectNameField.GetComponent<InputField>();
        subjectName = subjectName.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterName()
    {
        subjectName.text = subjectNameField.text;
    }
}
