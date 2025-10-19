using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private FukidasiSelect _fSelect = default;
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
        if (_damageCount >= 1)
        {
            switch (_damageCount)
            {
                case 1:
                    _enemyPause0.SetActive(false);
                    _enemyPause1.SetActive(true);
                    enemyPauseNum++;
                    break;
                case 2:
                    _enemyPause1.SetActive(false);
                    _enemyPause2.SetActive(true);
                    enemyPauseNum++;
                    break;
                case 3:
                    _enemyPause2.SetActive(false);
                    _enemyPause3.SetActive(true);
                    enemyPauseNum++;
                    break;
                case 4:
                    SceneManager.LoadScene("GameClear");
                    break;
            }
        }
    }
}
