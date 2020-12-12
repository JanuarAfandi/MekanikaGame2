using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    float scale_karakter;
    // Start is called before the first frame update
    void Start()
    {
        scale_karakter = GameObject.Find ("Stickman Idle").transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (scale_karakter == 0.8f){
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (12f, GetComponent<Rigidbody2D>().velocity.y);
        }else{
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (-12f, GetComponent<Rigidbody2D>().velocity.y);
        }
        
    }

    void OnTriggerEnter2D(Collider2D obj){
        if (obj.gameObject.name == "Batas1" || obj.gameObject.name == "Batas2"){
            Destroy (gameObject);
        }
    }
}
