using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public int _damageCount = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _damageCount += 3;
        }
    }

    private void FixedUpdate()
    {
        if (_damageCount >= 3)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
