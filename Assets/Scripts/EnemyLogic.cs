using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    float timeToMove = 0.5f;
    float timer = 0;
    int numbOfMovements = 0;
    float speed = 0.25f;
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

        if (numbOfMovements == 40)
        {
            transform.Translate(new Vector3(0, -1, 0));
            numbOfMovements = 0;
            speed = -speed;
        }
    }
}
