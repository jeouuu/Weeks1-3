using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HiderMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 hiderPos = transform.position;
        HiderApper(hiderPos);

        Vector2 screenSize = new Vector2(Screen.width,Screen.height);
        Vector2 screenSizeInWorld = Camera.main.ScreenToWorldPoint(screenSize);
        Vector2 screenZeroInWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);

        if (DistantFromMouse(hiderPos)) {
            transform.position = new Vector2(Random.Range(screenZeroInWorld.x, screenSizeInWorld.x), Random.Range(screenZeroInWorld.y, screenSizeInWorld.y));
        }
    }

    void HiderApper(Vector2 hiderPos) {
        if (Input.GetMouseButtonDown(0)) {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hiderPos = mousePos;
            transform.position = hiderPos;  
        }
    }

    bool DistantFromMouse(Vector2 hiderPos) {
        //get the mouwse pos
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //test
        Vector2 distant = mousePos - hiderPos;

        if (distant.x < 0.43 && distant.x > -0.60 && distant.y < 0.64 && distant.y > -0.28) {
            return true;
        }else {
            return false;
        }
    }
}
