using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float EnemySpeed = 0.05f;  //敵の移動速度
    public float MaxMoveRange = 5.0f; //敵の移動可能範囲
    private float MoveRange = 2.5f;   //敵の移動する起点
    private int Key = 0;              //敵の移動方向、0なら左に、１なら右に
    private Vector3 Enemy_pos;　　　　//敵の座標

    // Start is called before the first frame update
    void Start()
    {
        Enemy_pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (Key)
        {
            case 0:
                Enemy_pos.x += EnemySpeed;
                MoveRange -= EnemySpeed;
                break;
            case 1:
                Enemy_pos.x -= EnemySpeed;
                MoveRange += EnemySpeed;
                break;
            default:
                break;
        }

        if (MoveRange >= MaxMoveRange) Key = 0;
        if (MoveRange <= 0) Key = 1;

        gameObject.transform.position = Enemy_pos;
    }
}
