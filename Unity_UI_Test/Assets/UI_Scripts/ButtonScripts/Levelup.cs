using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Levelup : MonoBehaviour
{
    public TextMeshProUGUI valueText;
    int progress = 0;
    public Slider slider;



    public void OnSliderChanged(float value)
    {
        if (value >= 100f)
            ReduceCurrency.Instance.UpdateButtonVisibility(false);
        valueText.text = value.ToString();
       
    }
    public void UpdateProgress()
    {
        progress++;
        slider.value = progress;
     }

}
