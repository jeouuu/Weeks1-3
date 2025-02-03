using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMovement : MonoBehaviour
{

    //playermovement, knife follow the mouse
    

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        KnifeMove(mousePos);
    }

    void KnifeMove(Vector2 mousePos)
    {
        transform.position = mousePos;
    }

}
