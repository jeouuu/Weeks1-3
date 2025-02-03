using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public bool isFired = false;

    public SpriteRenderer sr;

    private void Start() {
        sr.color = Random.ColorHSV();  
    }

    void Update()
    {

        if (isFired)
        {
            Movement();
        }else
        {
            PointAtMouse();
        }
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }



    public void Fire()
    {
        isFired = true;
        transform.parent = null;
        Destroy(gameObject, 5f);
    }

    void Movement()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
