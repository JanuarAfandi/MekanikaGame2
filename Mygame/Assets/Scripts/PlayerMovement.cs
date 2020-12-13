using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMovement : MonoBehaviour
{
    //for joystick
    public Joystick joystick;

    public GameObject bullet,childShoot;

    Animator anim;
    Rigidbody2D rigid;

    public static float scaleX;
    public float speed = 10f;
    public float jump = 400f;
    float dirX = 0;
    float dirXJoystick = 0;
    bool isGround;

    int health = 100;
    void Start()
    {
        scaleX = transform.localScale.x;
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        //for joystick
        //dirXJoystick = joystick.Horizontal;
       // transform.Translate(new Vector2(dirXJoystick * speed * Time.deltaTime, 0f));

        //for button
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        transform.Translate(new Vector2(dirX * speed * Time.deltaTime, 0f));

        if (dirX < 0 || dirXJoystick < -0.2)
        {
            anim.SetTrigger("Walk");
            transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
        }
        else if (dirX > 0 || dirXJoystick > 0.2)
        {
            anim.SetTrigger("Walk");
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        }
        else
        {
            anim.SetTrigger("Stop");
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }

        if ((CrossPlatformInputManager.GetButtonDown("Jump") || joystick.Vertical > 0.5) && isGround)
        {
            rigid.velocity = Vector2.zero;
            rigid.AddForce(Vector2.up * jump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }

        if(collision.gameObject.tag == "BulletEnemy")
        {
            health -= 10;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, childShoot.transform.position, Quaternion.identity);
    }
}
