using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMessage : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
            Destroy(gameObject);
        }
    }
}