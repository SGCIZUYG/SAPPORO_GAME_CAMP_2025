using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void OnGameStart()
    {
        SceneManager.LoadScene("StageSelect");
        print("�X�e�[�W�Z���N�g��ʂֈڍs");
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
                print("�^�C�g���Ɉڍs");
                break;
            case ("GameScene"):
                SceneManager.LoadScene("Title");
                print("�^�C�g���Ɉڍs");
                break;
        }
    }

    public void OnDecisionStage()
    {
        SceneManager.LoadScene("GameScene");
        print("�Q�[���V�[���ֈڍs");
    }
}
