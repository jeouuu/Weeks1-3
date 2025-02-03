using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingGymSpawner : MonoBehaviour
{
    public GameObject cirPrefab;
    ColorChange currentCir;
    GameObject newCir;

    void Start()
    {

    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        if (Input.GetMouseButtonDown(0))
        {
            Spawn(mousePos);
        } else if (currentCir.overlap && Input.GetMouseButtonDown(1))
        {
            Destroy(currentCir.gameObject);
        }
    }

    void Spawn(Vector2 mousePos)
    {
        newCir = Instantiate(cirPrefab, mousePos, Quaternion.identity);
        newCir.transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 3), 0);
        ColorChange colorChangeScript = newCir.GetComponent<ColorChange>();
        if (colorChangeScript != null)
        {
            colorChangeScript.startColor = Random.ColorHSV();
        }
        if (currentCir.overlap) {
            currentCir = newCir.GetComponent<ColorChange>();
        }

    }
}
