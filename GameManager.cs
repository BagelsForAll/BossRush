using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameObject music;
    public GameObject healthbar;

    public void StartGame()
    {
        healthbar.SetActive(true);
    }

    public void EndGame()
    {
        Debug.Log("Game Over");
        Destroy(music);
        Time.timeScale = 0;
        SceneManager.LoadScene("DeathScreen", LoadSceneMode.Additive);
    }

    public void Victory()
    {
        Debug.Log("Victory!");
        Destroy(music);
        SceneManager.LoadScene("VictoryScreen", LoadSceneMode.Single);
    }
}
