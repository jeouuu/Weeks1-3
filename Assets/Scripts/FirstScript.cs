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

        //what we test on right
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeInWorld = new Vector2();
        screenSizeInWorld = Camera.main.ScreenToWorldPoint(screenSize);

        //what we test on left
        Vector2 screenZeroInWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x > screenSizeInWorld.x || pos.x < screenZeroInWorld.x)
        {
            speed *= -1;
        }

        transform.position = pos;

    }
}
