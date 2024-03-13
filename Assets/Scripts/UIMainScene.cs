using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainScene : MonoBehaviour
{
    public static UIMainScene instance;

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
