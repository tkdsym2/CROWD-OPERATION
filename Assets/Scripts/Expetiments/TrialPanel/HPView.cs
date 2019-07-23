using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPView : MonoBehaviour
{
     public GameObject studyManager;
    private StudyManager sm;

    private Text hpView;
    private int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        sm = studyManager.GetComponent<StudyManager>();
        hpView = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sm.isStartSession) ShowHP();
    }

    private void ShowHP()
    {
        int currentHP = sm.HP;
        hpView.text = currentHP.ToString() + "/100"; 
    }
}
