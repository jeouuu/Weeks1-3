using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaserMovement : MonoBehaviour
{

    public float speed = 0.5f;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetMouseButton(1)) {
            Vector2 pos = transform.position;
            Vector2 mouseaPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 dir = mouseaPos - pos;
            dir.Normalize();

            pos += dir * speed * Time.deltaTime;
            transform.position = pos;
        }
    
    }
}
