using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyPress : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Fire!");
        }
    }
}
