using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float WalkSpeed = 1000f;
    public float JumpForce = 500f;
    public float MaxSpeed = 500f;
    private float Speedx;
    private int key = 1;
    private bool isGround = true;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Speedx = Mathf.Abs(rigidbody.velocity.x);

        if (Input.GetKey(KeyCode.D) && Speedx <= MaxSpeed)
        {
            key = 1;
            rigidbody.AddForce(transform.right * key * WalkSpeed);
        }

        if (Input.GetKey(KeyCode.A) && Speedx <= MaxSpeed)
        {
            key = -1;
            rigidbody.AddForce(transform.right * key * WalkSpeed);
        }



        if (Input.GetKeyDown(KeyCode.W) && isGround == true)
        {
            rigidbody.AddForce(transform.up * JumpForce);
            isGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
}
