using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        Debug.Log("QUIT");
        Application.Quit();
    }
}
