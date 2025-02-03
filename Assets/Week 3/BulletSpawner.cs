using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Bullet currentBullet;

    void Start()
    {
    }

    void Update()
    {  

        if (Input.GetKeyDown(KeyCode.Space) && currentBullet == null) 
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0) && currentBullet != null)
        {
            currentBullet.Fire();
            currentBullet = null;
        }
        

    }

    void Spawn()
    {
        GameObject newBullet = Instantiate(bulletPrefab,transform);
        currentBullet = newBullet.GetComponent<Bullet>(); 
    }

    //void Fire()
    //{
    //    bullet.hasBeenFired = true;
    //    bullet = null;
    //}
}
