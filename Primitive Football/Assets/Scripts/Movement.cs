using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    Rigidbody rb;
    float x,z;
    public float MoveSpeed = 1000f;

    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
    }
    void Update()
    {
        x = Input.GetAxis("Vertical");
        z = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(x* MoveSpeed*Time.deltaTime,rb.velocity.y,-z* MoveSpeed*Time.deltaTime);
        //** Super speed --- rb.AddForce(x* MoveSpeed * Time.deltaTime, 0 ,-z * MoveSpeed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
