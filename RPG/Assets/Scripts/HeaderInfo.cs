using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class HeaderInfo : MonoBehaviourPun
{
    public TextMeshProUGUI nameText;
    public Slider bar;
    private float maxValue;

    public void Initialize(string text, int maxVal)
    {
        nameText.text = text;
        maxValue = maxVal;
        bar.minValue = 0.0f;
        bar.maxValue = maxValue;
        bar.value = 1.0f;
    }

    [PunRPC]
    void UpdateHealthBar (int value)
    {
        bar.value = (float)value / maxValue;
    }
}
