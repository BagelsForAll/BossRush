using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBoss : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            LoadBossLevel();
        }
    }
    public void LoadBossLevel()
    {
        // Load the boss fight and video
        SceneManager.LoadScene("Boss Rush v1", LoadSceneMode.Single);
    }
}
