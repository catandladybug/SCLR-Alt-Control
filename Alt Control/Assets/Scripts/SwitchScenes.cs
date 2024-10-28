using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public GameObject Start;
    public GameObject Instruct;

    public void StartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Reset()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void BackToStart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }

    public void Instructions()
    {
        Start.SetActive(false);
        Instruct.SetActive(true);
    }


}
