using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 squarePos = transform.position;

        //squarePos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //squarePos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //transform.position = squarePos;

        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        transform.Rotate(0, 0, (Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime)*-1);

    }
}
