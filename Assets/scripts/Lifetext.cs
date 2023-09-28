using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifetext : MonoBehaviour
{
    public GameObject lifetext = null;
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
        Text life = lifetext.GetComponent<Text>();
        life.text = "LIFE:" + script.life;
        Debug.Log(script.life);
    }
}
