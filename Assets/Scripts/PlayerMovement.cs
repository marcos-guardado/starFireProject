using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocity;
    public GameObject bulletPrefab;
    public GameObject bulletSpawner;
    private Rigidbody2D shipRB;
    private float horizontal;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        shipRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        shipRB.velocity = new Vector2(horizontal * velocity, vertical * velocity);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawner.transform.position, Quaternion.identity);
    }
}
