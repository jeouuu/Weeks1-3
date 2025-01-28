using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    //bird movement. Bird will fly toward the mouse pos

    public float speed = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //get mouise pos and object pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = transform.position;

        //calculate the distant between mouse position and object position
        Vector2 direction = mousePos - pos;
        //normalize it,and keep the direction
        direction.Normalize();
        
        //change it back to the bird position
        pos += direction * speed * Time.deltaTime;
        transform.position = pos;


    }
}
