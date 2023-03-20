using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
        [SerializeField] float time;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Invoke("ReloadScene", time);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
