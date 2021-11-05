using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate = 0.5f;
    public float nextFire = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void fire()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
    }
}
