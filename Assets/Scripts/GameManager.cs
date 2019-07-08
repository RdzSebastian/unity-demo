using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEndend = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject gameOverUI;

    public bool GetGameHasEndend()
    {
        return this.gameHasEndend;
    }


    public void CompleteLevel()
    {
        //Debug.Log("LEVEL WON!");
        FindObjectOfType<AudioManager>().Play("levelComplete");
        completeLevelUI.SetActive(true);
    }


    public void EndGame()
    {
        if(gameHasEndend == false)
        {
            gameHasEndend = true;
            //Debug.Log("END GAME");
            gameOverUI.SetActive(true);
            //Invoke("gameOver", restartDelay);
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("r") && gameHasEndend)
        {
            FindObjectOfType<AudioManager>().Play("Button");
            FindObjectOfType<GameManager>().Restart();
        }
    }
}
