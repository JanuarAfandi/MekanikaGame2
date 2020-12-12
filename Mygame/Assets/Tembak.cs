using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tembak : MonoBehaviour
{
    public GameObject PlayerBullet, Pos_Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseDown(){
        Instantiate (PlayerBullet, Pos_Bullet.transform.position, Pos_Bullet.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
