using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float WalkSpeed = 1000f; //移動力
    public float JumpForce = 500f;　//ジャンプ力
    public float MaxSpeed = 500f;   //制限速度
    private float Speedx;           //x方向の速さ
    private float Speedz;           //z方向の速さ
    private int xKey = 1;          //1の時右に移動、-1の時に左に移動
    private int zKey = 1;           //-1の時に手前に移動、1の時に奥に移動
    public bool isGround = true;    //着地判定,trueで着地,falseで離陸
    Rigidbody rigidbody;            //RigidBodyComponentを取得する変数
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Speedx = Mathf.Abs(rigidbody.velocity.x); //x方向の速さを取得
        Speedz = Mathf.Abs(rigidbody.velocity.z); //z方向の速さを取得

        if (Input.GetKey(KeyCode.D) && Speedx <= MaxSpeed)
        {
            xKey = 1;
            rigidbody.AddForce(transform.right * xKey * WalkSpeed);
        }

        if (Input.GetKey(KeyCode.A) && Speedx <= MaxSpeed)
        {
            xKey = -1;
            rigidbody.AddForce(transform.right * xKey * WalkSpeed);
        }

        if (Input.GetKey(KeyCode.S) && Speedx <= MaxSpeed)
        {
            zKey = -1;
            rigidbody.AddForce(transform.forward * zKey * WalkSpeed);
        }

        if (Input.GetKey(KeyCode.W) && Speedx <= MaxSpeed)
        {
            zKey = 1;
            rigidbody.AddForce(transform.forward * zKey * WalkSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
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
