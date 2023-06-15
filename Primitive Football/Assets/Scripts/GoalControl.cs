using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalControl : MonoBehaviour
{
    public int goal = 0;
    [SerializeField] GameObject Win_Screen;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GoalPost"))
        {
            goal = PlayerPrefs.GetInt("Score",0);
            goal++;
            Win_Screen.gameObject.SetActive(true);
            PlayerPrefs.SetInt("Score",goal);
            Destroy(other.gameObject);
            
        }
    }
}
