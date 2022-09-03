using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIState : MonoBehaviour
{
    // when player touching this collider, Come to next level
    [SerializeField] private GameObject boardUI;
    [SerializeField] private GameObject pushUI;
    [SerializeField] private GameObject settindUI;
    public static bool iswinner;
    public static bool GameIsPaused;
    void Start()
    {
        boardUI.SetActive(false);
        pushUI.SetActive(false);
        settindUI.SetActive(false);
        iswinner = false;
        GameIsPaused = false;
    }
    void Update()
    {
        if (HealthState.gameOver) // If Player Gameover
        {
            StartCoroutine(UIDelay());
        }
        UpdatePause();
    }
    private void OnTriggerEnter2D(Collider2D collLevel)
    {
        // Pass Level
        if (collLevel.gameObject.tag == "Level")
        {
            boardUI.SetActive(true);
            iswinner = true;
            FindObjectOfType<AudioManager>().PlaySound("Win");
        }
    }
    IEnumerator UIDelay()
    {
        yield return new WaitForSeconds(1.5f);
        boardUI.SetActive(true);
    }
    // Open UI 
    public void OpenSetting()  // Setting Menu
    {
        boardUI.SetActive(false);
        settindUI.SetActive(true);
    }
    public void CloseSetting()  // Setting Menu
    {
        boardUI.SetActive(true);
        settindUI.SetActive(false);
    }
    // Pause State
    void UpdatePause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pushUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pushUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    // FullScreen set
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
