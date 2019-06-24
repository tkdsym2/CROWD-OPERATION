using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoftwareCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Input.mousePosition;
        float x = position.x;
        float y = position.y;
        float ax = Input.GetAxis("Mouse X");
        float ay = Input.GetAxis("Mouse Y");

        this.GetComponent<Text>().text = "Software Cursor Property" +
                "\nx position: " + x.ToString() +
                "\ny position: " + y.ToString() +
                "\nx axis: " + ax.ToString() +
                "\ny axis: " + ay.ToString();
    }
}
