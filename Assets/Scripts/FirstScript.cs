using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    float speed; 

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.01f, 0.03f) ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;
        //pos.y += speed;
        if (pos.x > 5.5f || pos.x < -5.5f)
        {
            speed *= -1;
        }
        /*if(pos.y > 5.8f || pos.y < -5.8f)
        {
            speed *= -1;   
        }*/
        transform.position = pos;

    }
}
