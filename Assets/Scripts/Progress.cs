using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{

    public Transform player;
    public Transform END;
    public Text scoreText;
    public float playerPosition = 0f;


    void Update()
    {
        if (!FindObjectOfType<GameManager>().GetGameHasEndend() && playerPosition < 100f)
        {
            Debug.Log(playerPosition);
            //scoreText.text = player.position.z.ToString("0");
            playerPosition = (player.position.z * 100) / END.position.z;
            scoreText.text = playerPosition.ToString("0") + "%";
        }
        
    }
}
