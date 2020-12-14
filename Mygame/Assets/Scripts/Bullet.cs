using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject player;

    bool left, right;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        if (player.transform.localScale.x > 0)
        {
            right = true;
            //   transform.position += transform.right * 10f * Time.deltaTime;
        }
        else
        {
            right = false;
        }
    }

    private void Update()
    {
        if (right)
        {
            transform.position += transform.right * 10f * Time.deltaTime;
        }
        else
        {
            transform.position -= transform.right * 10f * Time.deltaTime;
        }

        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Batas")
        {
            Destroy(gameObject);
        }
    }
}
