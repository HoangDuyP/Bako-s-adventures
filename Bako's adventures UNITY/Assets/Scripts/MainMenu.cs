using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    int level;
    public Animator transition;
    public void PlayContinue()
    {
        SceneLevel data = SaveSystem.LoadLevel();
        if(data != null)
        {
            level = data.Level;
        }
        else
        {
            level = 1;
        }
        StartCoroutine(LoadContinueLevel());
    }
    public void PlayNewGame()
    {
        StartCoroutine(LoadTutorialLevel());
    }
    IEnumerator LoadContinueLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(0f);
        SceneManager.LoadSceneAsync(level);
    }
    IEnumerator LoadTutorialLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(0f);
        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
