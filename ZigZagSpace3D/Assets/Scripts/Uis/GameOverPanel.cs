using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
