using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletLogic : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    private Rigidbody2D rigibody2D;
    // Start is called before the first frame update
    void Start()
    {

        rigibody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rigibody2D.velocity = Vector2.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Debug.Log("Toque nave enemiga");
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(bullet);
        }
    }
}
