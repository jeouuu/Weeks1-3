using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();

    }

    void MovePlayer() {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        if(Input.GetAxis("Horizontal") == -1) {
            Vector2 scale = transform.localScale;
            scale.x = -1;
            transform.localScale = scale;
        }
        if (Input.GetAxis("Horizontal") == 1) {
            Vector2 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;
        }
    }
}
