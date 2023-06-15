using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System; 

public class TimeDecrease : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeRem;
    [SerializeField] float AllotedTime = 58f;
    [SerializeField] GameObject OriginalObject;
    [SerializeField] GameObject DeadMsg;

    // Update is called once per frame
    void Update()
    {
        if (AllotedTime > 0.1)
        {
            timeRem.text = "Time remaining : "+ Math.Floor(AllotedTime) +" Seconds";
            AllotedTime = AllotedTime - Time.deltaTime;
        }
        else
        {
            OriginalObject.GetComponent<Rigidbody>().isKinematic = true;
            OriginalObject.GetComponent<Movement>().enabled = false;
            DeadMsg.SetActive(true);
        }
    }
}
