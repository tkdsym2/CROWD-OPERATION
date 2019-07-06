using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExAddDummyButton : MonoBehaviour
{
    public GameObject exManager;
    private ExperimentalManager em;
    private List<int> dummyNumSession;
    private InputField inputField;
    private Text sessionView;
    // Start is called before the first frame update
    void Start()
    {
        em = exManager.GetComponent<ExperimentalManager>();
        dummyNumSession = em.dummyNumSession;
        inputField = GameObject.Find("DummyClonesAmplifer").GetComponent<InputField>();
        sessionView = GameObject.Find("CurrentDummySettings").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if(inputField.text != "") {
            int _num = int.Parse(inputField.text);
            dummyNumSession.Add(_num);
            inputField.text = "";
            string _temp = "Session: ";
            for(int i = 0; i < em.dummyNumSession.Count; i++)
            {
                _temp = _temp + em.dummyNumSession[i].ToString() + ", ";
            }
            sessionView.text = _temp;
        }
    }
}
