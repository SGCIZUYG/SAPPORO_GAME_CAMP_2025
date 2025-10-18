using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void OnGameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
