using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System; 
using UnityEngine.SceneManagement;

public class RespawnControl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI respawn;
    [SerializeField] float timer = 3;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Score") < 3)
        {
            respawn.text = "Respawn in " + Math.Floor(timer);
            timer = timer - Time.deltaTime;
            if (timer < 0.1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                this.transform.parent.gameObject.SetActive(false);
            }
        }
        else
        {
            respawn.text = "Next Level in " + Math.Floor(timer);
            timer = timer - Time.deltaTime;
            if (timer < 0.1)
            {
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                PlayerPrefs.SetInt("Score",0);
            }
        }
    }
}
