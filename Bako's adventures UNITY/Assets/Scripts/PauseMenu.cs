using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public Animator transition;
    public AudioSource BGM;
    public void Resume()
    {
        BGM.UnPause();
    }
    public void LoadMenuScene()
    {
        StartCoroutine(LoadMainMenu());
    }
    IEnumerator LoadMainMenu()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(0f);
        SceneManager.LoadSceneAsync(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
