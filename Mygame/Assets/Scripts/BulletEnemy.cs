using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    GameObject enemy;
    bool right;
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");

        if (enemy.transform.localScale.x > 0)
        {
            right = true;
            //   transform.position += transform.right * 10f * Time.deltaTime;
        }
        else
        {
            right = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            transform.position -= transform.right * 10f * Time.deltaTime;
        }
        else
        {
            transform.position += transform.right * 10f * Time.deltaTime;
        }
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Batas")
        {
            Destroy(gameObject);
        }
    }
}
