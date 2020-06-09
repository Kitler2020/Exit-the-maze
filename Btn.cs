using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    public Button LoadButton;

    void Start()
    {
        Button btn = LoadButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        LoadGame();
    }

    void LoadGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}