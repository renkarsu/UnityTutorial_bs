using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGameOverScene : MonoBehaviour
{
    GameObject player;
    PlayerController playerControllerScript;
    bool gameOverFlag;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        playerControllerScript = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        gameOverFlag = playerControllerScript.GameOverFlag;
        if (gameOverFlag)
        {
            SceneManager.LoadScene("gameOverScene");
            gameOverFlag = false;
        }
    }

}
