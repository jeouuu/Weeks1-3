using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    //cars move related to the mouse position

    //use the animation curve to smooth out the animation
    public AnimationCurve curve;
    public float carSpeed = 0.5f;
    [Range(0, 1)] public float t = 0;

    //variables for the start and end position
    public Vector2 start;
    public Vector2 end;

    void Start()
    {

    }

    void Update()
    {
        //get the mouse position
        // Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //incriment the time, so it moves from A -> B
        //when it reach 1, multiply the speed by -1 so it move back from B -> A
        //when it reach 0, multiply the speed by -1 so it move back from A -> B
        //therefore car loop between A and B
        t += Time.deltaTime * carSpeed;
        if (t > 1) {
           carSpeed *= -1;
        }if (t < 0) {
            carSpeed *= -1;
        }

        //use lerp for the movement, 
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));


    }
}
