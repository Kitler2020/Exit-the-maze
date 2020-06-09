using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeChange : MonoBehaviour
{
    public Slider slider;
    public Text valueCount;

    void Update()
    {
        valueCount.text = slider.value.ToString();
        AudioListener.volume = slider.value;

        if(Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}