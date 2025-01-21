using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public List<GameObject> spawnedThings;


    void Start()
    {
        spawnedThings = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            GameObject newThing = Instantiate(prefab, mousePos, Quaternion.identity);

            //different sizes
            newThing.transform.localScale = Vector3.one * Random.Range(0.3f, 1f);

            //add newthing in a list
            spawnedThings.Add(newThing);
            
            //different speed
            FirstScript myScript = newThing.GetComponent<FirstScript>();
            if(myScript != null) {
                myScript.speed = Random.Range(2, 6);
            }

            Destroy(newThing, 2);  
        }
    }
}
