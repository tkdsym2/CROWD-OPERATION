using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ExDummyCreator : MonoBehaviour
{
    private StudyManager sm;
    public GameObject dummyPrefab;
    private float drx, dry, drangle;
    private GameObject[] dummies;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("StudyManager").GetComponent<StudyManager>();
        dummies = new GameObject[1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateDummyCursor(int _num)
    {
        DestroyClones(dummies.Length);
        Array.Clear(dummies, 0, dummies.Length);
        dummies = new GameObject[sm.dummyNum];
        for (int i = 0; i < _num; i++)
        {
            dummies[i] = Instantiate(dummyPrefab) as GameObject;
            drx = UnityEngine.Random.Range(-9.0f, 9.0f);
            dry = UnityEngine.Random.Range(-5.0f, 5.0f);
            drangle = sm.minAngle + i * (360-2*sm.minAngle)/(float)(_num - 1);
            Vector3 pos = new Vector3(drx, dry, drangle);
            dummies[i].transform.position = new Vector3(drx, dry, drangle);
            dummies[i].transform.parent = transform;
        }
    }

    private void DestroyClones(int _num)
    {
        for(int i = 0; i < _num; i++){
            DestroyImmediate(dummies[i]);
        }
    }
}
