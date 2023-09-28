using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maker : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, transform.rotation);
        InvokeRepeating("Spawn",0f,1f);
    }

    void Spawn() {
        Instantiate(ball, new Vector3(Random.Range(-5f,5f),transform.position.y, transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
