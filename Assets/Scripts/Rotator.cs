using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0)) {
            //reset the world position
            transform.position = Vector3.zero;
            transform.eulerAngles = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.Space)) {
            //reset the locoal position
            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
        }
    }
}
