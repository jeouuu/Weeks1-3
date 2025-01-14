using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Vector2 speed;
    float direction = -1;

    // Start is called before the first frame update
    void Start()
    {
        speed = new Vector2(Random.Range(1f, 10f), Random.Range(1f, 10f));
    }

    // Update is called once per frame
    void Update()
    {
        //get the circle to move 
        Vector2 cirPos = transform.position;
        cirPos.x += speed.x * Time.deltaTime;
       // cirPos.y += speed.y * 2f * Time.deltaTime;
        transform.position = cirPos;

        //check boundaries 
        //transform the ball position from world to space
        Vector2 cirScreenPos = Camera.main.WorldToScreenPoint(cirPos);
        if(cirScreenPos.x < 0)
        {
            Vector2 fixedPos = new Vector2(0, 0);
            cirPos.x = fixedPos.x;
            cirPos.x = speed.x * direction * Time.deltaTime;
        }
        if ( cirScreenPos.x > Screen.width )
        {
            Vector2 fixedPos = new Vector2(Screen.width, 0);
            cirPos.x = fixedPos.x;
            cirPos.x += speed.x * direction ;
            //Debug.Log("touch");
        }
        if (cirScreenPos.y < 0)
        {
            Vector2 fixedPos = new Vector2(0, 0);
            cirPos.y = fixedPos.y;
            cirPos.y += speed.y * direction * Time.deltaTime;
        }
        if (cirScreenPos.y > Screen.height)
        {
            Vector2 fixedPos = new Vector2(0, Screen.height);
            cirPos.y = fixedPos.y;
            cirPos.y += speed.y * direction * Time.deltaTime;
        }

        //use up/down to change the size
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector2 cirSize = transform.localScale;
            cirSize.x += 0.5f;
            cirSize.y += 0.5f;
            transform.localScale = cirSize;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector2 cirSize = transform.localScale;
            cirSize.x -= 0.5f;
            cirSize.y -= 0.5f;
            transform.localScale = cirSize;
        }

        //use left/right to change the speed
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed -= new Vector2(1, 1); 
        }

        Debug.Log(speed.x);

    }
}
