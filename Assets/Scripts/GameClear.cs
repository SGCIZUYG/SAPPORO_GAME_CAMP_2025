using UnityEngine;

public class GameClear : MonoBehaviour
{
    public int EHP = 0;

    void Update()
    {
        if (EHP == 0)
        {
            SceneScript.Instance.LoadGameClearScene("GameClear");
        }
    }

}

