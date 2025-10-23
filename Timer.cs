using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minute;
    public float second;
    
    void Update()
    {
        second -= Time.deltaTime;

        if (second <= 0)
        {
            if (minute > 0)
            {
                second += 59;
                minute--;
            }
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex); 
        }
    }
}
