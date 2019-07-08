using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExDummyCursorVisual : MonoBehaviour
{
    private StudyManager sm;
    private SpriteRenderer spriteRenderer;
    public Sprite defaultCursor;
    public Sprite circleCursor;
    public Sprite squareCursor;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StudyManager").GetComponent<StudyManager>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        ChangeCursorVisual(0);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCursorVisual(sm.selectedVisual);
    }

    private void ChangeCursorVisual(int _num)
    {
        switch(_num)
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
