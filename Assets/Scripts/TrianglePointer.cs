using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrianglePointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse location from screen to world
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //remember to set the z=0, or else it will takes the mouse.z = -10 (outside the camera)
        mousePos.z = 0;
        Vector2 pointDir = mousePos - transform.position; 

        transform.up = pointDir;
    }
}
