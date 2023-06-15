using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrentLevel : MonoBehaviour
{
    public Slider current_L_value;
    [SerializeField] TextMeshProUGUI Level_Displayed;

    // Update is called once per frame
    void Update()
    {
        Level_Displayed.text = current_L_value.value.ToString();
    }
}
