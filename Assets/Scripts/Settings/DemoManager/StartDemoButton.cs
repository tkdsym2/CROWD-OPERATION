using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDemoButton : MonoBehaviour
{
    public GameObject demoManager;
    private DemoManager dm;
    // Start is called before the first frame update
    void Start()
    {
        dm = demoManager.GetComponent<DemoManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        dm.ChangeScene();
    }
}
