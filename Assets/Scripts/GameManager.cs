using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEndend = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

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
            Debug.Log("END GAME");
            Invoke("Restart", restartDelay);
        }
        
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
