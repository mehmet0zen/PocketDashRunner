using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;

    void Update() 
    {
        if (Input.GetMouseButton(0) || Input.touchCount > 0)
        {
            Vector3 cursorPos = Input.mousePosition;
            if (Input.touchCount > 0)
                cursorPos = Input.GetTouch(0).position;

            Vector3 worldCursorPos = Camera.main.ScreenToWorldPoint(new Vector3(cursorPos.x, cursorPos.y, transform.position.z - Camera.main.transform.position.z));

            float diff = worldCursorPos.x - transform.position.x;

            rb.velocity = new Vector3(diff, 0, 1) * speed;
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 1);
        }
    }
}
