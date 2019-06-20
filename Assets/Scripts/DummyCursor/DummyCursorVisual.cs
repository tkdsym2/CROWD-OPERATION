using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCursorVisual : MonoBehaviour
{
    private StatusManager sm;
    private SpriteRenderer spriteRenderer;
    public Sprite defaultCursor, discoveredCursor;
    public Sprite circleCursor, discoveredCircleCursor;
    public Sprite squareCursor, discoveredSquareCursor;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StatusManager").GetComponent<StatusManager>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = squareCursor;
    }

    // Update is called once per frame
    void Update()
    {
        switch(sm.selectedVisual)
            {
                case 0:
                    spriteRenderer.sprite = squareCursor;
                    break;
                case 1:
                    spriteRenderer.sprite = circleCursor;
                    break;
                case 2:
                    spriteRenderer.sprite = defaultCursor;
                    break;
                default:
                    break;
            }
    }
}
