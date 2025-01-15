using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTank();
    }

    void MoveTank() {
        transform.Translate( Input.GetAxis("Horizontal") * speed.x * Time.deltaTime, 0,0);
    }
}
