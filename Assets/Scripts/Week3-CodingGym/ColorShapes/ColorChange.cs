using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color startColor = Color.white;
    public bool overlap = false;
   
    void Start()
    {
        
    }


    void Update()
    {

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = transform.position;

        Vector2 halfSize = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
        if (mousePos.x<pos.x+halfSize.x && mousePos.x > pos.x - halfSize.x / 2 && mousePos.y < pos.y + halfSize.y && mousePos.y > pos.y - halfSize.y) {
            overlap = true;
            spriteRenderer.color = Color.red;
        } else {
            overlap = false;
            spriteRenderer.color = startColor;
        }

        if (overlap) {
            if (Input.GetMouseButtonDown(1)) {
                Destroy(gameObject);
            }
        }
        Debug.Log(overlap);
    }
}

