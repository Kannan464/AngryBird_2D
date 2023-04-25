using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Ingame;
    public GameObject Level;

    public void PlayPressed()
    {
        MainMenu.SetActive(false);
        Ingame.SetActive(true);
    }
    public void MainMenuPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        MainMenu.gameObject.SetActive(true);
        Ingame.gameObject.SetActive(true);
        Level.gameObject.SetActive(false);
    }
    
        
}
