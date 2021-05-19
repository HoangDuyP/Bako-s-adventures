using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPauseMenu : MonoBehaviour
{
    public GameObject Shiba;
    public GameObject Shiba_Alter;
    public GameObject PauseMenu;
    public AudioSource BGM;
    void Update()
    {
        TriggerPause();
    }
    void TriggerPause()
    {
        if (Input.GetButtonDown("Pause"))
        {
            Shiba.SetActive(false);
            Shiba_Alter.SetActive(false);
            PauseMenu.SetActive(true);
            BGM.Pause();
        }
    }
}
