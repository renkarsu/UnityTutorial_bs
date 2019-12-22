using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public int offset = 1;     //弾を発射する際にプレイヤーと被らないようにするためのオフセット
    private GameObject player; //プレイヤーを取得するための変数
    private Vector3 playerpos; //プレイヤーの座標
    public GameObject BulletPrehab; //弾のPrehabを格納する変数

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject; //親オブジェクトであるplayerを取得
    }

    // Update is called once per frame
    void Update()
    {
        playerpos = player.transform.position; //プレイヤーの位置を取得

        if (Input.GetKeyDown(KeyCode.Return))  //弾の生成
        {
            Instantiate(BulletPrehab, new Vector3(playerpos.x, playerpos.y, playerpos.z + offset), Quaternion.identity);
        }
    }
}
