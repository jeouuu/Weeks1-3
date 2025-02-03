using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color startColor = Color.white;
    public bool overlap;
   
    void Start()
    {
        
    }


    void Update()
    {

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = transform.position;

        if (Overlap(mousePos, pos))
        {
            spriteRenderer.color = Color.red;
        } else
        {
            spriteRenderer.color = startColor;
        }

        overlap = Overlap(mousePos, pos);
        Debug.Log(overlap);
      
    }

     bool Overlap(Vector2 mousePos, Vector2 pos)
    {
        Vector2 halfSize = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
        if (mousePos.x < pos.x + halfSize.x && mousePos.x > pos.x - halfSize.x / 2 && mousePos.y < pos.y + halfSize.y && mousePos.y > pos.y - halfSize.y)
        {
            return true;
        } else
        {
            return false;
        }
    }

}

