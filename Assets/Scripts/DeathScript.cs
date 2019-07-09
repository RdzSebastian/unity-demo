using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour
{
    public static int deaths = 0;

    // Start is called before the first frame update
    Text DeathCounter;
    void Start()
    {
        DeathCounter = GetComponent<Text>();
    }
    void Update()
    {
        DeathCounter.text = "Deaths: " + deaths;
    }
}
