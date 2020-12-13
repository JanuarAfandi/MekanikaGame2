using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject bullet, childShoot;
    float timer;
    int health = 100;

    public static float scaleX;

    public GameObject player;
    void Start()
    {
        scaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(player != null)
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 0.05f);

        if(transform.position.x < player.transform.position.x)
        {
            transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
        }
        else if (transform.position.x > player.transform.position.x)
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }

        if (timer > 0.1f)
        {
            Instantiate(bullet, childShoot.transform.position, Quaternion.identity);
            timer = 0f;
        }

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BulletPlayer")
        {
            health -= 10;
        }
    }

}
