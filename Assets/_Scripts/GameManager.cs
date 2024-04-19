using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static int score;
    public int scoreLimit = 9;
    public TextMeshProUGUI tmpText;
    public float delayInSeconds = 5f;

    private void Start()
    {
        tmpText.enabled = false;
    }
    public static void incrementScore()
    {
        score++;
    }

    private void Update()
    {
        if (score == scoreLimit)
        {
            tmpText.enabled = true;
            StartCoroutine(LoadSceneCoroutine());
        }
    }

    IEnumerator LoadSceneCoroutine()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(delayInSeconds);

        // Load the scene
        SceneManager.LoadScene("Menu");
    }



}
