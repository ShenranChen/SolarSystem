using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonBehavior : MonoBehaviour
{
    public TextMeshProUGUI buttonText; 
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        Update();

    }

    // Update is called once per frame
    void Update()
    {
        if (buttonText != null)
        {
            buttonText.text = isPaused ? "Resume" : "Pause";
        }
    }

    public void OnClick()
    {
        isPaused = !isPaused;
        Update();

        if (isPaused)
        {
            Time.timeScale = 0f;  // Pause the game
        }
        else
        {
            Time.timeScale = 1f;  // Unpause the game
        }
    }
}
