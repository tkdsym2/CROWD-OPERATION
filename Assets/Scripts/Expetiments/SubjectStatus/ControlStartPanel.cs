using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStartPanel : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private CanvasGroup canvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        canvasGroup = gameObject.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(sm.isStartStudy)
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
        else
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }
    }
}
