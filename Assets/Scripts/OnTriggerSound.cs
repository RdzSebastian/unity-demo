using UnityEngine;

public class OnTriggerSound : MonoBehaviour
{

    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            //Debug.Log("We hit a SoundColider");
            FindObjectOfType<AudioManager>().Play("movement");
        }
    }
}
    
            
