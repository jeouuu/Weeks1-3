using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingGymSpawner : MonoBehaviour
{
    public GameObject cirPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bool overlap = cirPrefab.GetComponent<ColorChange>().overlap;

        if (overlap == false) {
            if (Input.GetMouseButtonDown(0)) {
                cirPrefab.transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 3), 0);
                GameObject newCir = Instantiate(cirPrefab, mousePos, Quaternion.identity);
                ColorChange colorChangeScript = newCir.GetComponent<ColorChange>();
                if (colorChangeScript != null) {
                    colorChangeScript.startColor = Random.ColorHSV();
                }
                overlap = false;
            }
            
        }

       
    }
}
