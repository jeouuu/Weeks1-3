using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTest : MonoBehaviour
{
    // clouds movement in x direction overtimme, when it reach the edge  zero of the screen return to the origin position 

    [Range(0, 1)] public float t = 0;
    public float cloudSpeed = 1f;


    Vector2 screenSize;
    Vector2 screenWorldSize;
    Vector2 screenWorldSizeZero;

    public float offset = 5f;
    public Vector2 start;
    public Vector2 end;


    void Start()
    {
        //get the screen size from screen to world -> check boundary
        screenSize = new Vector2(Screen.width, Screen.height);
        screenWorldSize = Camera.main.ScreenToWorldPoint(screenSize);
        screenWorldSizeZero = Camera.main.ScreenToWorldPoint(Vector2.zero);
    }


    void Update()
    {
        //set the start location at the right edge, end location at the left edge, keep the original y position of the ogject.      
        start = new Vector2(screenWorldSize.x + offset, transform.position.y);
        end = new Vector2(screenWorldSizeZero.x - offset, transform.position.y);

        //incriment the time, when it reach 1(which is the left edge) set it back to 0 (right edge).
        t += Time.deltaTime * cloudSpeed;
        if (t > 1) {
            t = 0;
            start = new Vector2(screenWorldSize.x + offset, transform.position.y);
        }
        //use vector2 lerp to do the movement
        transform.position = Vector2.Lerp(start, end, t);

    }
}
