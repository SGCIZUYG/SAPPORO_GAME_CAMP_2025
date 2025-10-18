using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void OnGameStart()
    {
        SceneManager.LoadScene("GameScene");
        print(222);
    }

    public void OnExit()
    {
        Application.Quit();
        print(111);
    }
}
