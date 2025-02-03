using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BaarrelSpawner : MonoBehaviour
{

    public GameObject barrelPrefab;
    GameObject newBarrel;
    public List<GameObject> barrels;

    private void Start()
    {
        barrels = new List<GameObject>();   
    }


    void Update()
    {
        if ( barrels.Count < 5)
        {
            Spawn();
        }

        foreach (GameObject b in barrels)
        {
            Barrel barrelScript = b.GetComponent<Barrel>();
            if (barrelScript != null && barrelScript.lose == true)
            { 
                Restart();
            }
        }

    }

    void Spawn()
    {
        Vector2 screenEdge = new Vector2 (Screen.width, Screen.height);
        Vector2 screenEdgeInWorld = Camera.main.ScreenToWorldPoint (screenEdge);
        Vector2 screenZeroInWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);
        Vector2 randomPos = new Vector2(Random.Range(screenZeroInWorld.x, screenEdgeInWorld.x), Random.Range(screenZeroInWorld.y, screenEdgeInWorld.y));
        newBarrel = Instantiate(barrelPrefab, randomPos, Quaternion.identity);
        barrels.Add(newBarrel);
    }

    void Restart()
    {
        foreach (GameObject b in barrels)
        {
            Destroy(b);
        }
        barrels.Clear();
        if (barrels.Count < 5)
        {
            Spawn();
        }
    }

}
