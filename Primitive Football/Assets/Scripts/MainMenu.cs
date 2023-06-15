using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider forSliderValue;
    public void PlayGame()
    {
        PlayerPrefs.SetInt("Score",0);
        int SceneValue = (int)forSliderValue.value;
        SceneManager.LoadScene(SceneValue);
    }

    public void QuitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
