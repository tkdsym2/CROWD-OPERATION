using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisteringSubject : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private InputField subjectNameField;
    public Canvas timerPanel;
    private IntervalTimerViewController itvc;
    public Canvas startPanel;
    private ControlStartPanel csp;
    public Text intervalTimer;
    private IntervalTimer it;
    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        subjectNameField = GameObject.Find("SubjectNameField").GetComponent<InputField>();
        itvc = timerPanel.GetComponent<IntervalTimerViewController>();
        csp = startPanel.GetComponent<ControlStartPanel>();
        it = intervalTimer.GetComponent<IntervalTimer>();
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
            csp.HideStartPanel();
            itvc.ShowIntervalTimer();
        }
    }
}
