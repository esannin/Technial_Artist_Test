using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroySceneObjects : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }
}