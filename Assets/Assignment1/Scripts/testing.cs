using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    //test when mouse hover on the object(window), the sprite change to the selcet sprite

    public SpriteRenderer spriteRenderer;
    public Sprite select;
    public Sprite original;

    void Start()
    {
        
    }

    void Update()
    {
        //get mouse pos and object pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 objPos = transform.position;

        //calculate the halfsize of the object, so we know where's the edge of object
        Vector2 halfSize = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);

        if(overlap(mousePos, objPos, halfSize)) {
            spriteRenderer.sprite = select;
            Debug.Log("touch");
        } else {
            spriteRenderer.sprite = original;
            Debug.Log("not touch");
        }

    }

    bool overlap(Vector2 pos1, Vector2 pos2, Vector2 halfSize) {
        if (pos1.x < pos2.x + halfSize.x && pos1.x > pos2.x - halfSize.x && pos1.y < pos2.y + halfSize.y && pos1.y > pos2.y - halfSize.y) {
            return true;
        } else {
            return false;
        }
    }

}
