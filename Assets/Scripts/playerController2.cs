using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //scene内の赤い矢印(x軸)が向いてる方向をtransform.rightは示す.
            //objectの向いてる向きではないので,objectをsceneの座標と別の向きに配置すると
            //右にいってほしくてもゲーム制作者から見て前に向かったりする.
            rb.velocity = transform.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = -transform.right * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
                                               //x, y,  z
            rb.velocity = new Vector3(0, 0, 1) * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0, 0, -1) * speed;
        }
    }

}
