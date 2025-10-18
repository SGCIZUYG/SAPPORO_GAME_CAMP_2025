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
   
    Debug.Log("�V�[���u" + GameScene + "�v�ւ̑J�ڂ����s���܂��B");
    SceneManager.LoadScene(GameScene);
    }

    public void LoadTitleScene(string TitleScene)
    {

        Debug.Log("�V�[���u" + TitleScene + "�v�ւ̑J�ڂ����s���܂��B");
        SceneManager.LoadScene(TitleScene);
    }

    public void LoadGameOverScene(string GameOverScene)
    {

        Debug.Log("�V�[���u" + GameOverScene + "�v�ւ̑J�ڂ����s���܂��B");
        SceneManager.LoadScene(GameOverScene);
    }

    public void LoadGameClearScene(string GameClearScene)
    {

        Debug.Log("�V�[���u" + GameClearScene + "�v�ւ̑J�ڂ����s���܂��B");
        SceneManager.LoadScene(GameClearScene);
    }


}