using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorView : MonoBehaviour
{
    public GameObject statusManager;
    private StatusManager sm;
    // define sprite
    SpriteRenderer MainSpriteRenderer;
    public Sprite defaultCursor;
    public Sprite discoveredCursor;
    private bool isDiscover = false;
    // Start is called before the first frame update
    void Start()
    {
        sm = statusManager.GetComponent<StatusManager>();
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = defaultCursor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) sm.isDiscover = !sm.isDiscover;
        if(Input.GetKeyDown("r") && sm.isDiscover) sm.isDiscover = !sm.isDiscover;

        if (sm.isDiscover)
        {
            MainSpriteRenderer.sprite = discoveredCursor;
        }
        else
        {
            MainSpriteRenderer.sprite = defaultCursor;
        }
    }
}
