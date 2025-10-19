using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private GameObject _stanp = default;
    [SerializeField] private GameObject _enemyPause0 = default;
    [SerializeField] private GameObject _enemyPause1 = default;
    [SerializeField] private GameObject _enemyPause2 = default;
    [SerializeField] private GameObject _enemyPause3 = default;
    public int _damageCount = 0;
    private int enemyPauseNum = 0;

    private void Start()
    {
        _stanp.SetActive(false);
        _enemyPause0.SetActive(true);
        _enemyPause1.SetActive(false);
        _enemyPause2.SetActive(false);
        _enemyPause3.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (enemyPauseNum)
            {
                case 0:
                    _enemyPause0.SetActive(false);
                    _enemyPause1.SetActive(true);
                    enemyPauseNum++;
                    break;
                case 1:
                    _enemyPause1.SetActive(false);
                    _enemyPause2.SetActive(true);
                    enemyPauseNum++;
                    break;
                case 2:
                    _enemyPause2.SetActive(false);
                    _enemyPause3.SetActive(true);
                    enemyPauseNum++;
                    break;
                case 3:
                    SceneManager.LoadScene("GameClear");
                    break;
            }
        }
    }
}
