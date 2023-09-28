using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour

{
    public GameObject scoretext = null;
    GameObject p;
    paddle script;

    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("p");
        script = p.GetComponent<paddle>();
    }

    // Update is called once per frame
    void Update()
    {
        Text s = scoretext.GetComponent<Text>();
        s.text = "SCORE:" + script.Score;
        
    }
}
