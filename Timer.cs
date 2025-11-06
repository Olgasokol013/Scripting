using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minute;
    public float second;
    public TextMeshProUGUI timerText;
    
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
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
        int roundSecond = Mathf.RoundToInt(second);
        timerText.text = minute + ":" + roundSecond;
    }
}
