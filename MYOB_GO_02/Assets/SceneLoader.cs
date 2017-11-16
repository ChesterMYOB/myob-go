using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Button yourButton;
    public string ScenePath;


    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(ScenePath);
    }



    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        LoadScene();
    }
}
