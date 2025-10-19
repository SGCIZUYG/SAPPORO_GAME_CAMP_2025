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


    public void LoadGameScene(string GameScene)
    {

        Debug.Log("シーン「" + GameScene + "」への遷移を実行します。");
        SceneManager.LoadScene(GameScene);
    }

    public void LoadGameSelectScene(string GameSelect)
    {

        Debug.Log("シーン「" + GameSelect + "」への遷移を実行します。");
        SceneManager.LoadScene(GameSelect);
    }


    public void LoadTitleScene(string Title)
    {

        Debug.Log("シーン「" + Title + "」への遷移を実行します。");
        SceneManager.LoadScene(Title);
    }

    public void LoadGameOverScene(string GameOver)
    {

        Debug.Log("シーン「" + GameOver + "」への遷移を実行します。");
        SceneManager.LoadScene(GameOver);
    }

    public void LoadGameClearScene(string GameClear)
    {

        Debug.Log("シーン「" + GameClear + "」への遷移を実行します。");
        SceneManager.LoadScene(GameClear);
    }
}

