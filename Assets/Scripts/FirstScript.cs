using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    public float speed = 0.1f;

    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    void Start() {
        //spriteRenderer.color = Random.ColorHSV();

        if (sprites.Length == 0) {

        } else {
            spriteRenderer.sprite = sprites[Random.Range(0,sprites.Length)];
        }
        
    }

    void Update()
    {
        Vector2 pos = transform.position;
        //keep consistency
        pos.x += speed * Time.deltaTime;

        //1st method/////////////////////////////////////////////////////////////
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
 
        //what we test on right
        Vector2 screenSizeInWorld = new Vector2();
        screenSizeInWorld = Camera.main.ScreenToWorldPoint(screenSize);
   
        //what we test on left
        Vector2 screenZeroInWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (pos.x > screenSizeInWorld.x)
        {
            Vector3 fixedPos = new Vector3(screenSizeInWorld.x, 0, 0);
            pos.x  = fixedPos.x;
            speed *= -1;
        }
        if (pos.x < screenZeroInWorld.x) {
            Vector3 fixedPos = new Vector3(screenZeroInWorld.x, 0, 0);
            pos.x = fixedPos.x;
            speed *= -1;
        }
        //////////////////////////////////////////////////////////////////////////

        /* 2nd method/////////////////////////////////////////////////////////////
         * 
         * transform the square pos in world to screen
         * Vector2 squareScreenPos = Camera.main.WorldToScreenPoint(pos);
         * 
         * if(squareScreenPos.x < 0){
         *   Vector3 fixedPos = new Vector3(0, 0, 0);
         *   pos.x  = Camera.main.ScreenToWorldPoint(fixedPos).x;
         *   speed *= -1;
         * }
         * if(squareScreenPos.x > Screen.width){
         *   Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
         *   pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
         *   speed *= -1;
         * }
         *////////////////////////////////////////////////////////////////////////

        transform.position = pos;

    }
}
