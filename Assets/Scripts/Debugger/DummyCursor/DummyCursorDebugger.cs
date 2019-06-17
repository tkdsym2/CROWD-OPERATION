using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyCursorDebugger : MonoBehaviour
{
    public GameObject textPrefab;
    private GameObject text;
    // private GameObject text;
    DummyCursorMove cloneScript;
    Vector3 clonePosition;
    int hoge;
    // Start is called before the first frame update
    void Start()
    {

        cloneScript = textPrefab.GetComponent<DummyCursorMove>();
        Debug.Log(cloneScript.hoge);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Vector3 _pos = cloneScript.clone;
    //    Vector3 pos = new Vector3(_pos.x, _pos.y, 0);
    //    //float dx = gameObject.transform.position.x;
    //    //float dy = gameObject.transform.position.y;
    //    //float dangle = gameObject.transform.position.z;
    //    //Vector3 pos = new Vector3(dx, dy, 0);
    //    Vector3 converted = Camera.main.WorldToScreenPoint(pos);
    //    //converted.x = converted.x - Screen.width / 2 + 230;
    //    //converted.y = converted.y - Screen.height / 2 - 40;
    //    gameObject.GetComponent<RectTransform>().localPosition = pos;
    //    gameObject.GetComponent<Text>().text = "x: " + converted.x.ToString() +
    //            ", y: " + converted.y.ToString() +
    //            ", angle: " + _pos.z.ToString();
    //}
}
