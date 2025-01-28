using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{

    bool trigger = false;
    public SpriteRenderer color;

    void Start()
    {
        
    }


    void Update()
    {

        //get mouse pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = transform.position;

        //calculate the edges of the circle.
        //when the mouse is in the circle and pressed, then it is trigger
        //if it is click again the trigger is equal to no trigger, so it works like a switch instead. 
        Vector2 halfSize = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
        if (mousePos.x < pos.x + halfSize.x && mousePos.x > pos.x - halfSize.x / 2 && mousePos.y < pos.y + halfSize.y && mousePos.y > pos.y - halfSize.y) {
            if (Input.GetMouseButtonDown(0)) {
                trigger = !trigger;
            }
            Debug.Log("touch");
        } else {
            //trigger = false;
            Debug.Log("not touch");
        }

        //if mouse is trigger turn green, else click again turn red
        if (trigger) {
            color.color = Color.green;
        } else {
            color.color = Color.red;
        }

    }
}
