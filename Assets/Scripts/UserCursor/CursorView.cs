using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorView : MonoBehaviour
{
    public GameObject statusManager;
    private StatusManager sm;
    // define sprite
    private SpriteRenderer MainSpriteRenderer;
    public Sprite defaultCursor, discoveredCursor;
    public Sprite circleCursor, discoveredCircleCursor;
    public Sprite squareCursor, discoveredSquareCursor;
    private bool isDiscover = false;
    // Start is called before the first frame update
    void Start()
    {
        sm = statusManager.GetComponent<StatusManager>();
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = squareCursor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !sm.isStarted) sm.isDiscover = !sm.isDiscover;
        if (Input.GetKeyDown("r") && sm.isDiscover) sm.isDiscover = !sm.isDiscover;

        if (sm.isDiscover)
        {
            switch(sm.selectedVisual)
            {
                case 0:
                    MainSpriteRenderer.sprite = discoveredSquareCursor;
                    break;
                case 1:
                    MainSpriteRenderer.sprite = discoveredCircleCursor;
                    break;
                case 2:
                    MainSpriteRenderer.sprite = discoveredCursor;
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch(sm.selectedVisual)
            {
                case 0:
                    MainSpriteRenderer.sprite = squareCursor;
                    break;
                case 1:
                    MainSpriteRenderer.sprite = circleCursor;
                    break;
                case 2:
                    MainSpriteRenderer.sprite = defaultCursor;
                    break;
                default:
                    break;
            }
        }
    }
}
