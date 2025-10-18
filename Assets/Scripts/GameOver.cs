using UnityEngine;

public class GameOver : MonoBehaviour
{
    public int HP = 0;
    
    void Update()
    {
        if (HP == 0)
        {
            SceneScript.Instance.LoadGameOverScene("");
        }
    }

}

