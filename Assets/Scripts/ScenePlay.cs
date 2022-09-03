using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePlay : MonoBehaviour
{
    [SerializeField] public string sceneToLoad;
    [SerializeField] public string nextLevelScene; // next level
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
    public void PlayGame()    // Load Scene for button click
    {
        SceneManager.LoadScene("Scene00_1");
    }
    public void QuitGame()    // Exit Game Botton click
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("Scene00");
    }

    public void MenuButton()  // Return Map
    {
        SceneManager.LoadScene("Scene00_1");
    }
    public void NextButton()  // Next Level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(nextLevelScene);
    }
    public void ReturnButton()  // Play this Level again
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Scene Play //
    public void Scene01()
    {
        SceneManager.LoadScene("Scene01");
    }
}
