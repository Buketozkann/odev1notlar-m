//using System.Collections;
//using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class LevelRestart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


  
}
