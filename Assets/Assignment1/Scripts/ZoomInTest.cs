using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class ZoomInTest : MonoBehaviour
{
    // test for the zoom in function

    public AnimationCurve curve;
    [Range(0, 1)] public float t = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 objPos = transform.position;

        //calculate the halfsize of the object, so we know where's the edge of object
        Vector2 halfSize = new Vector2(transform.localScale.x / 2, transform.localScale.y / 2);

        if (overlap(mousePos, objPos, halfSize)) {
            t += Time.deltaTime;
            if (t > 1) {
                t = 0;

            }
           transform.localScale = Vector2.one * curve.Evaluate(t);
            Debug.Log("touch");
        } else {
            //if (t > 0) {
            //    t -= Time.deltaTime;
            //}
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
