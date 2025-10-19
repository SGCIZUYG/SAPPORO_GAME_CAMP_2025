using UnityEngine;

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
        _stanp.active = false;
        _enemyPause0.active = true;
        _enemyPause1.active = false;
        _enemyPause2.active = false;
        _enemyPause3.active = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _damageCount++;
            switch (enemyPauseNum)
            {
                case 0:
                    _enemyPause0.active = false;
                    _enemyPause1.active = true;
                    enemyPauseNum++;
                    break;
                case 1:
                    _enemyPause1.active = false;
                    _enemyPause2.active = true;
                    enemyPauseNum++;
                    break;
                case 2:
                    _enemyPause2.active = false;
                    _enemyPause3.active = true;
                    enemyPauseNum++;
                    break;
            }
        }
    }
}
