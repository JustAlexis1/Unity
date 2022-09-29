using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject Load;
    [SerializeField] GameObject Options;
    public int sceneID = 0;
    public void OptionsMenuOpen()
    {
        Options.SetActive(true);
    }
    public void LoadMenuOpen()
    {
        Load.SetActive(true);
    }
    public void OptionsMenuClose()
    {
        Options.SetActive(false);
    }
    public void LoadMenuClose()
    {
        Load.SetActive(false);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}