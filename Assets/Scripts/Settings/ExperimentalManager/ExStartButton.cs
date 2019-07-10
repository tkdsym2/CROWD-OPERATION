using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExStartButton : MonoBehaviour
{
    public GameObject experimentalManager;
    private ExperimentalManager em;
    // Start is called before the first frame update
    void Start()
    {
        em = experimentalManager.GetComponent<ExperimentalManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        em.ChangeScene();
    }
}
