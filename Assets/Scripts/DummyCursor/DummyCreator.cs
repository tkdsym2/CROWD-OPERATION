using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DummyCreator : MonoBehaviour
{
    private StatusManager sm;

    public GameObject dummyPrefab;
    private float drx, dry, drangle;
    private GameObject[] dummies;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StatusManager").GetComponent<StatusManager>();
        dummies = new GameObject[sm.dummyNum];
        GenerateDummyCursor(sm.dummyNum);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")) 
        {
            destroyClones(dummies.Length);
            Array.Clear(dummies, 0, dummies.Length);
            dummies = new GameObject[sm.dummyNum];
            GenerateDummyCursor(sm.dummyNum);
        }
    }

    private void GenerateDummyCursor(int _num)
    {
        for (int i = 0; i < _num; i++)
        {
            dummies[i] = Instantiate(dummyPrefab) as GameObject;
            drx = UnityEngine.Random.Range(-9.0f, 9.0f);
            dry = UnityEngine.Random.Range(-5.0f, 5.0f);
            drangle = UnityEngine.Random.Range(sm.minRotation, sm.maxRotation);
            Vector3 pos = new Vector3(drx, dry, drangle);
            dummies[i].transform.position = new Vector3(drx, dry, drangle);
            dummies[i].transform.parent = transform;
        }
    }

    private void destroyClones(int _num){
        for(int i = 0; i < _num; i++){
            DestroyImmediate(dummies[i]);
        }
    }
}
