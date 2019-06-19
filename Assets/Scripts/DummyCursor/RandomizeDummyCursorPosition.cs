using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeDummyCursorPosition : MonoBehaviour
{
    private StatusManager sm;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StatusManager").GetComponent<StatusManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) RandomizeCursorPos();
    }

    private void RandomizeCursorPos()
    {
        float drx = UnityEngine.Random.Range(-9.0f, 9.0f);
        float dry = UnityEngine.Random.Range(-5.0f, 5.0f);
        float drangle = Random.Range(sm.minRotation, sm.maxRotation);
        gameObject.transform.position = new Vector3(drx, dry, drangle);
    }
}
