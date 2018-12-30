using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanKillPlayer : MonoBehaviour {

    public GameManager myGameManager;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        { // check if it's the player, if you want
            EndTheGame();
            Destroy(other.gameObject);
        }
    }

    public void EndTheGame()
    {
        myGameManager.EndGame();
    }
}
