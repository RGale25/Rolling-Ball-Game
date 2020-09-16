using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int totalCollectables = 1;
    public int collected = 0;
    public Text scoreText;
    public Text timeText;
    public Text timeTaken;
    public Text coinsCollected;
    public Canvas levelCanvas;
    public Canvas endCanvas;
    public float timer = 0.0f;
    public string finalTime;
    public PlayerMovement movement;
    public Vector3 spawnPoint = new Vector3(-23, 2, 23);

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "(0/10) Collectables";
        levelCanvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timeText.text = (timer.ToString("0") + " Seconds");
        scoreText.text = ("(" + collected.ToString() + "/" + totalCollectables.ToString() + ") Collectables");
    }

    public void incCollected()
    {
        collected = collected + 1;
    }

    public void levelComplete()
    {
        finalTime = timer.ToString("0");
        movement.enabled = false;
        levelCanvas.enabled = false;
        endCanvas.enabled = true;
        timeTaken.text = (finalTime + " Seconds");
        coinsCollected.text = (collected + " / " + totalCollectables);
        
    }

    public void quitLevel()
    {
        SceneManager.LoadScene("MainMenuScene");
        SceneManager.UnloadScene("GameScene");
    }
}
