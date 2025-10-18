using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void OnGameStart()
    {
        SceneManager.LoadScene("StageSelect");
        print("ステージセレクト画面へ移行");
    }

    public void OnExit(string nowScene)
    {
        switch (nowScene)
        {
            case ("Title"):
                Application.Quit();
                print(111);
                break;
            case ("StageSelect"):
                SceneManager.LoadScene("Title");
                print("タイトルに移行");
                break;
            case ("GameScene"):
                SceneManager.LoadScene("Title");
                print("タイトルに移行");
                break;
        }
    }

    public void OnDecisionStage()
    {
        SceneManager.LoadScene("GameScene");
        print("ゲームシーンへ移行");
    }
}
