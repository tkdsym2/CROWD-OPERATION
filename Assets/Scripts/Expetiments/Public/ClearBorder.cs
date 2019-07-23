using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBorder : MonoBehaviour
{
    public GameObject clearBorder;
    private LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = clearBorder.GetComponent<LineRenderer>();
        Vector3 startPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/2, 0));
        Vector3 endPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height/2, 0));
        lineRenderer.SetWidth(0.01f, 0.01f);
        lineRenderer.SetVertexCount(2);
        lineRenderer.SetPosition(0, new Vector3(-9.0f, 4.5f, 0));
        lineRenderer.SetPosition(1, new Vector3(9.0f, 4.5f, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
