using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTest : MonoBehaviour
{
    //testing for clouds movement

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
        screenSize = new Vector2(Screen.width, Screen.height);
        screenWorldSize = Camera.main.ScreenToWorldPoint(screenSize);
        screenWorldSizeZero = Camera.main.ScreenToWorldPoint(Vector2.zero);
    }


    void Update()
    {
      
        start = new Vector2(screenWorldSize.x + offset, transform.position.y);
        end = new Vector2(screenWorldSizeZero.x - offset, transform.position.y);

        t += Time.deltaTime * cloudSpeed;
        if (t > 1) {
            t = 0;
            start = new Vector2(screenWorldSize.x + offset, transform.position.y);
        }
        transform.position = Vector2.Lerp(start, end, t);

    }
}
