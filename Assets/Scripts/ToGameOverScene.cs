using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGameOverScene : MonoBehaviour
{
    GameObject player;
    PlayerHitpoint playerHitpointScript;
    bool gameOverFlag;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        playerHitpointScript = player.GetComponent<PlayerHitpoint>();
    }

    // Update is called once per frame
    void Update()
    {
        gameOverFlag = playerHitpointScript.GameOverFlag;
        if (gameOverFlag)
        {
            SceneManager.LoadScene("gameOverScene");
            gameOverFlag = false;
        }
    }

}
