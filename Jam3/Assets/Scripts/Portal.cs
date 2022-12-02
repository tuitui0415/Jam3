using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{   

    public GameObject portal;
    public GameObject player;


    private void OnTriggerEnter2D(Collider2D collision) {
        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name == "player") {
            player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        } 
    }
}
