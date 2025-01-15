using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class InvaderMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(0f,-5f);
    public float offset = 5f;

    // Update is called once per frame
    void Update() {
        //move the invader, march down
        Vector2 pos = transform.position;

        MoveInvader(pos);
        ReachGround(pos);
    }

    private void MoveInvader(Vector2 pos) {
        pos.y += speed.y * Time.deltaTime;
        transform.position = pos;
    }

    private void ReachGround(Vector2 pos) {
        Vector2 invaderScreenPos = Camera.main.WorldToScreenPoint(pos);
        if(invaderScreenPos.y <= 0 + offset) {
            speed = new Vector2(0, 0);
        }
    }
}
