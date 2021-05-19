using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    public int level;
    public Animator transition;
    public float transition_time = 1f;
    int Count;
    private void Start()
    {
        SaveSystem.SaveLevel(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            Count++;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Count == 2)
        {
           StartCoroutine(LoadLevel());
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            Count--;
        }
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transition_time);
        SceneManager.LoadSceneAsync(level);
    }
}
