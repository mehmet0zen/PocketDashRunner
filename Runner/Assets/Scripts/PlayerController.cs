using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int dir = (Input.GetKey(KeyCode.RightArrow) ? 1:0) - (Input.GetKey(KeyCode.LeftArrow) ? 1:0);
        rb.velocity = new Vector3(dir, 0, 0) * speed;
    }

    void FixedUpdate() 
    {

    }
}
