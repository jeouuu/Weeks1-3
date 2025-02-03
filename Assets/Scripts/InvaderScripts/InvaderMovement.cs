using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class InvaderMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f,0f);
    public float offset = 5f;
    bool reachEdge = false;

    void Update() {

        //move the invader, horizontally
        Vector2 pos = transform.position;

        Vector2 posInScreen = Camera.main.WorldToScreenPoint(pos);

        if (posInScreen.x > Screen.width )
        {
            Vector2 fixedPos = new Vector2(Screen.width -1, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            transform.position = pos;
            reachEdge = true;
        } else if (posInScreen.x < 0)
        {
            Vector2 fixedPos = new Vector2(0 + 1, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            transform.position = pos;
            reachEdge = true;
        } else
        {
            reachEdge= false;
        }

        if (reachEdge) 
        {
            MoveInvaderVertical(pos);
            speed.x *= -1;
         
        } else
        {
            MoveInvaderHorizontal(pos); 
        }

        ReachGround(pos);
    }

    private void MoveInvaderHorizontal(Vector2 pos) {
        pos.x += speed.x * Time.deltaTime;
        transform.position = pos;
    }

    private void MoveInvaderVertical(Vector2 pos)
    {
        pos.y = pos.y - 1;
        transform.position = pos;
        reachEdge = false;
    }

    private void ReachGround(Vector2 pos) {
        Vector2 invaderScreenPos = Camera.main.WorldToScreenPoint(pos);
        if(invaderScreenPos.y <= 0 + offset) {
            speed = new Vector2(0, 0);
        }
    }
}
