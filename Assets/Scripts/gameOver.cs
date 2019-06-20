using UnityEngine;

public class gameOver : MonoBehaviour
{
    public void GameOver()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        FindObjectOfType<GameManager>().Restart();
    }
}
