using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paddle : MonoBehaviour
{
    //private float speed;
    public float speed;
    public GameObject ball;
    public int life;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {

    
   
    //speed = 5f;
}

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")* Time.deltaTime*speed,0f,0f);
        //Debug.Log(transform.position.x);
        if (life <= 0) 
        {
            //Debug.Log("gameover");
            //Time.timeScale = 0;
            SceneManager.LoadScene("GO");
        }
        
        
    }
}
