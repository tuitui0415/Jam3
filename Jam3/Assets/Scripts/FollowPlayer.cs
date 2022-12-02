using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public float speed;
    private Transform targets;
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movePos = new Vector2(targets.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, movePos, speed * Time.deltaTime);
     
    }
}
