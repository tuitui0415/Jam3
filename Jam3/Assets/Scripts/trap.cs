using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{   
    public float timer;
     

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Trap"){
            GetComponent<Movement>().enabled = false;
            Invoke("enable",timer);
        }
    }

    private void enable(){
        GameObject.Find("player").GetComponent<Movement>().enabled = true;
        Destroy(this);
    }
}
