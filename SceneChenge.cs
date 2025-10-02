using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class SceneChenge : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerEnter()
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}