using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextScene : MonoBehaviour
{
    [SerializeField]
    string SceneName01;
    [SerializeField]
    string SceneName02;
    [SerializeField]
    string SceneName03;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene01()
    {
        SceneManager.LoadScene(SceneName01);
    }

    public void NextScene02()
    {
        SceneManager.LoadScene(SceneName02);
    }

    public void NextScene03()
    {
        SceneManager.LoadScene(SceneName03);
    }

}
