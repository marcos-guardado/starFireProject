using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBullet : MonoBehaviour
{
    public GameObject player;
    public Transform player_pos;
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Debug.Log("Toque nave enemiga");
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Destroy(player);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
