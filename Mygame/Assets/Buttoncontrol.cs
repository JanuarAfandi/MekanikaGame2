using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttoncontrol : MonoBehaviour
{
    public GameObject MovePlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        if (gameObject.name == "Button_Left"){

        }else if (gameObject.name == "Button_Right"){

        }else if (gameObject.name == "Button_Up"){
            MovePlayer.GetComponent<MovePlayer> ().jumping();

        }
    }

    void OnMouseUp(){
        if (gameObject.name == "Button_Left"){
            MovePlayer.GetComponent<MovePlayer> ().stop();
        }else if (gameObject.name == "Button_Right"){
            MovePlayer.GetComponent<MovePlayer> ().stop();
        }else if (gameObject.name == "Button_Up"){

        }
    }

    void OnMouseDrag(){
        if (gameObject.name == "Button_Left"){
            MovePlayer.GetComponent<MovePlayer> ().left();

        }else if (gameObject.name == "Button_Right"){
            MovePlayer.GetComponent<MovePlayer> ().right();

        }else if (gameObject.name == "Button_Up"){
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
