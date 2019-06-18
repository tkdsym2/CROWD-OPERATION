using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCanvasGroup : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    private bool isShow;

    // Start is called before the first frame update
    void Start()
    {
        isShow = false;
        canvasGroup = gameObject.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m")) isShow = !isShow;

        if (isShow)
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
