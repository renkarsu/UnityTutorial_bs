using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitpont : MonoBehaviour
{
    public int enemyhitpoint = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyhitpoint < 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            enemyhitpoint--;
        }
    }
}
