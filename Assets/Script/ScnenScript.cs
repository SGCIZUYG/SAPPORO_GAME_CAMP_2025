using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    
    public static SceneLoader Instance { get; private set; }

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

    public void LoadTitleScene(string TitleScene)
    {

        Debug.Log("シーン「" + TitleScene + "」への遷移を実行します。");
        SceneManager.LoadScene(TitleScene);
    }

    public void LoadGameOverScene(string GameOverScene)
    {

        Debug.Log("シーン「" + GameOverScene + "」への遷移を実行します。");
        SceneManager.LoadScene(GameOverScene);
    }

    public void LoadGameClearScene(string GameClearScene)
    {

        Debug.Log("シーン「" + GameClearScene + "」への遷移を実行します。");
        SceneManager.LoadScene(GameClearScene);
    }


}