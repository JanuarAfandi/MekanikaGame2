using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed, scaleX, jump;
    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
    }

    public void left(){
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("New State")){
            GetComponent<Animator> ().SetTrigger ("Walk");
        }
        transform.localScale = new Vector3 (-scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate (Vector3.left*speed*Time.fixedDeltaTime, Space.Self);
    }

    public void right(){
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("New State")){
            GetComponent<Animator> ().SetTrigger ("Walk");
        }
        transform.localScale = new Vector3 (scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate (Vector3.right*speed*Time.fixedDeltaTime, Space.Self);
    }

    public void stop(){
        GetComponent<Animator> ().SetTrigger ("Stop");
    }

    public void jumping(){
        GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, jump);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)){
            left ();
        }
        if (Input.GetKey (KeyCode.RightArrow)){
            right ();
        }
        if (Input.GetKeyDown (KeyCode.UpArrow)){
            jumping ();
        }

        if (Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow)){
            stop();
        }
    }
}
