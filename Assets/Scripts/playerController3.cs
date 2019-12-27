using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController3 : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    void Update()
    {
        //tips:プレイヤの向きはマウスで変えて横への移動をwasdでしたければ
        //transform.???(?, ?, ?) * Time.deltaTime * movementSpeed);
        //これを14行目のtransform.Rotateを消して？を埋めて上の記述を書くと
        //A,Dキーまたは右,左矢印はプレイヤの向きを変えるのではなく,横に移動するコマンドになる.
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }

}
