using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitpoint : MonoBehaviour
{
    public int HitPoint = 3;  //PlayerのHP
    public bool GameOverFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HitPoint < 1)
        {
            GameOverFlag = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            HitPoint--;
        }
    }
}
