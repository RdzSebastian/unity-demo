using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    
    void Update()
    {
        if (!FindObjectOfType<GameManager>().GetGameHasEndend())
        {
            //Debug.Log(player.position.z);
            scoreText.text = player.position.z.ToString("0");
        }
        
    }
}
