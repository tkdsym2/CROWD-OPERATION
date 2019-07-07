using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisteringSubject : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private InputField subjectNameField;
    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        subjectNameField = GameObject.Find("SubjectNameField").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(subjectNameField.text != "") {
            sm.subjectName = subjectNameField.text;
            sm.isStartStudy = !sm.isStartStudy;
        }
    }
}
