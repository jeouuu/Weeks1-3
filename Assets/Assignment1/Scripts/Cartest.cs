using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartest : MonoBehaviour
{

    //test for car movement inrelated to mouses pos

    public AnimationCurve curve;
    public float carSpeed = 0.5f;

    public Vector2 start;
    public Vector2 end;


    void Start()
    {
        
    }


    void Update()
    {
        //get mouse pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 carPos = transform.position;

      //  carPos = mousePos;

        
        transform.position = Vector2.Lerp(start,end,curve.Evaluate((mousePos.y-mousePos.x)*carSpeed));    


    }
}
