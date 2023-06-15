using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDeath : MonoBehaviour
{
    [SerializeField] GameObject BlueStopDeath;
    [SerializeField] GameObject TimeStop;
    void Start()
    {
        Destroy(BlueStopDeath.GetComponent<Death>());
        Destroy(TimeStop.GetComponent<TimeDecrease>());
        Destroy(TimeStop.GetComponent<AudioSource>());
    }

    
}
