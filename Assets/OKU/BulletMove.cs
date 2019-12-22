using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float BulletSpeed = 500;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        rigid.AddForce(transform.forward * BulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("destroybullet", 1.0f);
    }

    private void destroybullet()
    {
        Destroy(gameObject);
    }
}
