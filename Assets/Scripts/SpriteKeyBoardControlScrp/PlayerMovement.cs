using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float offset = 1;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();

    }

    void MovePlayer() {
        //move player
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        //check boundaries
        Vector2 playerScreenPos = Camera.main.WorldToScreenPoint(transform.position);
       
        if(playerScreenPos.x < 0+offset) {
            Vector3 fixedPos = new Vector3(0 + offset, 0, 0);
            playerScreenPos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            transform.position = new Vector3(playerScreenPos.x,transform.position.y,transform.position.z);

        }
        if (playerScreenPos.y < 0 + offset) {
            Vector3 fixedPos = new Vector3(0, 0 + offset, 0);
            playerScreenPos.y = Camera.main.ScreenToWorldPoint(fixedPos).y;
            transform.position = new Vector3(transform.position.x, playerScreenPos.y, transform.position.z);
        }
        if (playerScreenPos.x > Screen.width - offset) {
            Vector3 fixedPos = new Vector3(Screen.width - offset, 0, 0);
            playerScreenPos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            transform.position = new Vector3(playerScreenPos.x, transform.position.y, transform.position.z);
        }
        if (playerScreenPos.y > Screen.height - offset) {
            Vector3 fixedPos = new Vector3(0, Screen.height - offset, 0);
            playerScreenPos.y = Camera.main.ScreenToWorldPoint(fixedPos).y;
            transform.position = new Vector3(transform.position.x, playerScreenPos.y, transform.position.z);
        }

        if (Input.GetAxis("Horizontal") == -1) {
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
