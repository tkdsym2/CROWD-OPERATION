using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExJudgeArea : MonoBehaviour
{
    public GameObject studyManager;
    private StudyManager sm;
    private SpriteRenderer AreaSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        AreaSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        float cx = Screen.width/2;
        float cy = Screen.height/2;
        AreaSpriteRenderer.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
