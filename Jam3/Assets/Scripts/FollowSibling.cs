using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSibling : MonoBehaviour
{

    private Transform siblingPos;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        GameObject kid = GameObject.FindGameObjectWithTag("Kid1");
        siblingPos = kid.GetComponent<Transform>();
        Physics2D.IgnoreCollision(kid.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, siblingPos.position, Time.deltaTime * speed);
    }
}
