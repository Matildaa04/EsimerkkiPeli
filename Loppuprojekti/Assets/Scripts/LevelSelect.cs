using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}
