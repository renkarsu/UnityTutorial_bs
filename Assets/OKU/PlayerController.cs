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
    private int xKey = 1;           //1の時右に移動、-1の時に左に移動
    private int zKey = 1;           //-1の時に後ろに移動、1の時に前に移動
    private int offset = 1;         //発射した球とプレイヤーが被らないようにするためのオフセット
    public bool isGround = true;    //着地判定,trueで着地,falseで離陸
    public GameObject BulletPrehab;
    private Vector3 playerpos;
    Rigidbody rigidbody;            //RigidBodyComponentを取得する変数
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerpos = gameObject.transform.position;
        Speedx = Mathf.Abs(rigidbody.velocity.x); //x方向の速さを取得
        Speedz = Mathf.Abs(rigidbody.velocity.z); //z方向の速さを取得

        if (Input.GetKey(KeyCode.D) && Speedx <= MaxSpeed) //右に移動
        {
            xKey = 1;
            rigidbody.AddForce(transform.right * xKey * WalkSpeed);
        }

        if (Input.GetKey(KeyCode.A) && Speedx <= MaxSpeed)  //左に移動
        {
            xKey = -1;
            rigidbody.AddForce(transform.right * xKey * WalkSpeed);
        }

        if (Input.GetKey(KeyCode.S) && Speedx <= MaxSpeed)  //後ろに移動
        {
            zKey = -1;
            rigidbody.AddForce(transform.forward * zKey * WalkSpeed);
        }

        if (Input.GetKey(KeyCode.W) && Speedx <= MaxSpeed) //前に移動
        {
            zKey = 1;
            rigidbody.AddForce(transform.forward * zKey * WalkSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGround == true) //ジャンプ(ジャンプ中は再度ジャンプできない、無限ジャンプの禁止)
        {
            rigidbody.AddForce(transform.up * JumpForce);
            isGround = false;
        }

    }

    private void OnCollisionEnter(Collision collision)  //着地判定
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
}
