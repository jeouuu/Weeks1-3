using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{

    public float speed = 1f;
    public AnimationCurve curveY;
    public AnimationCurve curveZ;
    [Range(0, 1)] public float t;

    void Start()
    {
        t = 0;
    }


    void Update()
    {
        //move circle
        Vector3 pos = transform.position;
        pos.z = 0;
        pos.x += speed * Time.deltaTime;

        //check boundary
        //cir from world to screen 
        Vector2 cirScreenPos = Camera.main.WorldToScreenPoint(pos);

        if(cirScreenPos.x < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0,0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed *= -1;
        }
        if(cirScreenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0,0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed *= -1;
        }


        //get the space input
        if (Input.GetKey(KeyCode.Space))
        {
            t += Time.deltaTime;
            if (t > 1)
            {
                t = 0;
            }

            pos.y = curveY.Evaluate(t);
            pos.z = curveZ.Evaluate(t);

        }

        transform.position = pos;

    }
}
