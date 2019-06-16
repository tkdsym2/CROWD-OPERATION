using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorView : MonoBehaviour
{
    // define sprite
    SpriteRenderer MainSpriteRenderer;
    public Sprite defaultCursor;
    public Sprite discoveredCursor;
    private bool isDiscover = false;
    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = defaultCursor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d")) isDiscover = !isDiscover;

        if (isDiscover)
        {
            MainSpriteRenderer.sprite = discoveredCursor;
        }
        else
        {
            MainSpriteRenderer.sprite = defaultCursor;
        }
    }
}
