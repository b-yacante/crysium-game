using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float jumpSpeed = 5;
    private Rigidbody rb;
    private void Jump()
    {
        rb.AddForce(0, jumpSpeed, 0, ForceMode.Impulse);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
