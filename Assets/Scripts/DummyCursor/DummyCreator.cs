using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCreator : MonoBehaviour
{
    private ModeManager modeManager;

    public GameObject dummyPrefab;
    private int dummyNum;
    private float drx, dry, drangle;

    // Start is called before the first frame update
    void Start()
    {
        modeManager = GetComponent<ModeManager>();
        dummyNum = modeManager.dummyNum;
        for (int i = 1; i < 10; i++)
        {
            GameObject dummy = Instantiate(dummyPrefab) as GameObject;
            drx = UnityEngine.Random.Range(-9.0f, 9.0f);
            dry = UnityEngine.Random.Range(-5.0f, 5.0f);
            drangle = Random.Range(45, 360);
            dummy.transform.position = new Vector3(drx, dry, drangle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
