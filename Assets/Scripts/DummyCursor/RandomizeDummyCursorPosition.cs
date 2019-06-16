using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeDummyCursorPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
        float drangle = Random.Range(45, 360);
        gameObject.transform.position = new Vector3(drx, dry, drangle);
    }
}
