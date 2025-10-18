using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{

    public static SceneScript Instance { get; private set; }

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {

            Destroy(gameObject);
            return;
        }


        Instance = this;


        DontDestroyOnLoad(gameObject);
    }


    public void LoadGameScene(string Game)
    {

        Debug.Log("�V�[���u" + Game + "�v�ւ̑J�ڂ����s���܂��B");
        SceneManager.LoadScene(Game);
    }

    public void LoadTitleScene(string Title)
    {

        Debug.Log("�V�[���u" + Title + "�v�ւ̑J�ڂ����s���܂��B");
        SceneManager.LoadScene(Title);
    }

    public void LoadGameOverScene(string GameOver)
    {

        Debug.Log("�V�[���u" + GameOver + "�v�ւ̑J�ڂ����s���܂��B");
        SceneManager.LoadScene(GameOver);
    }

    public void LoadGameClearScene(string GameClear)
    {

        Debug.Log("�V�[���u" + GameClear + "�v�ւ̑J�ڂ����s���܂��B");
        SceneManager.LoadScene(GameClear);
    }
}

