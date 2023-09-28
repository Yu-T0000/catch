using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private float speed;
    GameObject p;
    paddle script;
    
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("p");
        speed = Random.Range(5f, 15f);
        script = p.GetComponent<paddle>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(0f, 0f, -1*speed*Time.deltaTime);
        if (transform.position.z < -13.0f) {
            script.life -= 1;
            Destroy(gameObject);
            
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("p")) {
            script.Score += 1;
            Destroy(gameObject);
          
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f,1.0f),0f, 0f);
            if (collision.gameObject.transform.localScale.x < 1.0f) {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
        }
        
    }
}
