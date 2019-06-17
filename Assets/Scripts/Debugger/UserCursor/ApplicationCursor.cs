using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationCursor : MonoBehaviour
{
    public GameObject appCursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = appCursor.transform.position.x;
        float y = appCursor.transform.position.y;
        Vector3 pos = Camera.main.WorldToScreenPoint(appCursor.transform.position);
        pos.x = pos.x - Screen.width/2 + 230;
        pos.y = pos.y - Screen.height/2 - 40;
        this.GetComponent<RectTransform>().localPosition = pos;
        this.GetComponent<Text>().text = "x: " + pos.x.ToString() +
                ", y: " + pos.y.ToString();
    }
}
