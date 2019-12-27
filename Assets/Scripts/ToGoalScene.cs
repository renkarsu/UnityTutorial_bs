using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGoalScene : MonoBehaviour
{
    bool flag_goal = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (flag_goal)
        {
            SceneManager.LoadScene("goalScene");
            flag_goal = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            flag_goal = true;
        }
    }

}