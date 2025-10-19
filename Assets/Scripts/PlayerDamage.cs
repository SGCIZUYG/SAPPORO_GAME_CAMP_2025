using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private FukidasiSelect _fk = default;
    public int _damageCount = 0;

    //private void Update()
    //{
    //    if ()
    //    {
    //        _damageCount += 3;
    //    }
    //}

    private void FixedUpdate()
    {
        if (_damageCount >= 3)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
