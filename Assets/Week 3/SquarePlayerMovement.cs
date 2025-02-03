using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquarePlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        movement();
        
    }

    void movement() {
        transform.Translate(Input.GetAxis("Horizontal")* speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
    }

}
