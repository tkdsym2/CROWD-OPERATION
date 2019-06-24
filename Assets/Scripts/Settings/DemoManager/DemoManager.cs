using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoManager : MonoBehaviour
{
    public float delayTime;// delay time forall cursor[ms]
    public int dummyNum;// amount of dummy cursor
    public float cdr;// control-display ratio
    public int minAngle;
    public int maxAngle;
    public int selectedVisual;

    void Awake()
    {
        delayTime = 0.0f;
        dummyNum = 12;
        cdr = 1.0f;
        minAngle = 30;
        maxAngle = 345;
        selectedVisual = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);// store for all scene
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("s")) ChangeScene();
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Demo", LoadSceneMode.Single);
    }
}
