using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Barrel : MonoBehaviour
{
    public float offset = 1f;
    int popOrNot =2;
    bool chance = true;
    public bool lose = false;


    public SpriteRenderer sr;
    public Sprite popSprite;

    void Start()
    {
        
    }


    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = transform.position;

        if(Overlap(mousePos, pos) && Input.GetMouseButtonDown(0) && chance)
        {
            chance = false;
            popOrNot = Random.Range(0, 2);
        }

        //0 = pop, 1 = not pop, 2 = nutral
        if (popOrNot == 0)
        {
            sr.sprite = popSprite;
            lose = true;
            popOrNot = 2;
        } else if (popOrNot == 1)
        {
            popOrNot = 2;
        }
    }

    bool Overlap(Vector2 mousePos, Vector2 pos)
    {
        Vector2 halfSize = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);
        if (mousePos.x < pos.x + halfSize.x + offset && mousePos.x > pos.x - halfSize.x - offset && mousePos.y < pos.y + halfSize.y + offset && mousePos.y > pos.y - halfSize.y - offset)
        {
            return true;
        } else
        {
            return false;
        }
    }

}
