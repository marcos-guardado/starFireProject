using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    float timeToMove = 0.5f;
    float timer = 0;
    int numbOfMovements = 0;
    public int maxNumbOfMovements;
    float speed = 0.25f;

    public GameObject bullet;
    public Transform punto_instancia;
    // public float fireRate = 0.5f;
    private float tiempo;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToMove)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numbOfMovements++;
        }

        if (numbOfMovements == maxNumbOfMovements)
        {
            transform.Translate(new Vector3(0, 1, 0));
            numbOfMovements = 0;
            speed = -speed;
        }

        tiempo += Time.deltaTime;
        if (tiempo >= 2)
        {
            Instantiate(bullet, punto_instancia.position, Quaternion.identity);
            tiempo = 0;
            // nextFire = Time.time + fireRate;
            //fire();
        }
    }
}
