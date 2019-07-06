using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyNumSessionViewer : MonoBehaviour
{
    public GameObject experimentalManager;
    private ExperimentalManager em;
    private Text text;
    private string sessionSummary;
    // Start is called before the first frame update
    void Start()
    {
        em = experimentalManager.GetComponent<ExperimentalManager>();
        text = gameObject.GetComponent<Text>();
        string sessionSummary = "Session: ";
        for(int i = 0; i < em.dummyNumSession.Count; i++)
        {
            sessionSummary = sessionSummary + em.dummyNumSession[i].ToString() + ", ";
        }
        text.text = sessionSummary;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
