using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TMP_Text scoreText;

    // Store the score value locally in this script
    private float scoreValue = 0f;

    private void Start()
    {
        // Initialize the scoreText in the Start method if it's not already assigned in the Inspector
        if (scoreText == null)
        {
            Debug.LogError("Please assign the Score Text in the Inspector.");
        }
    }

    private void Update()
    {
        // Update the displayed score in the UI
        scoreText.text = "Score: " + scoreValue.ToString();
    }

}
