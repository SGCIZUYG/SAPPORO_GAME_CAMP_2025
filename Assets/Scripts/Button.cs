using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void OnGameStart()
    {
        SceneManager.LoadScene("StageSelect");
        print(222);
    }

    public void OnExit()
    {
        Application.Quit();
        print(111);
    }

    public void OnDecisionStage()
    {
        SceneManager.LoadScene("GameScene");
;       print("ゲームシーンへ移行");
    }
}
