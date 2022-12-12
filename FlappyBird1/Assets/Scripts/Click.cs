using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

            SceneManager.LoadScene(1);
        }

    }
}