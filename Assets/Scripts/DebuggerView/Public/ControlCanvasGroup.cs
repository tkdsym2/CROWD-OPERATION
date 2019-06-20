using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCanvasGroup : MonoBehaviour
{
    public GameObject statusManager;
    private StatusManager sm;
    public CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        sm = statusManager.GetComponent<StatusManager>();
        canvasGroup = gameObject.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m") || Input.GetKeyDown("r")) {
            if(sm.isShowingDebugger) sm.isShowingDebugger = !sm.isShowingDebugger;
            Cursor.visible = false;
        }

        if (sm.isShowingDebugger)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }
        else
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
    }
}
