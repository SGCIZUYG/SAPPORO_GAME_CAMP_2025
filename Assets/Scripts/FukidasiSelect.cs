using UnityEngine;
using UnityEngine.UI;

public class FukidasiSelect : MonoBehaviour
{
    [SerializeField] private GameObject _fukidasi1 = default;
    [SerializeField] private GameObject _fukidasi2 = default;
    [SerializeField] private GameObject _fukidasi3 = default;
    [SerializeField] private GameObject _fukidasi4 = default;
    [SerializeField] private GameObject _fukidasi5 = default;
    [SerializeField] private EnemyDamage _eDamage = default;
    private UserScriptManager _usManager = default;

    private void Start()
    {
        _fukidasi1.SetActive(false);
        _fukidasi2.SetActive(false);
        _fukidasi3.SetActive(false);
        _fukidasi4.SetActive(false);
        _fukidasi5.SetActive(false);
        _usManager = GetComponent<UserScriptManager>();
    }

    private void Update()
    {
        if (_usManager._conversationFinished)
        {
            _fukidasi1.SetActive(true);
            _fukidasi2.SetActive(true);
            _fukidasi3.SetActive(true);
            _fukidasi4.SetActive(true);
            _fukidasi5.SetActive(true);
        }
    }
    public void OnFukidasiSelect(int fukidasiNum)
    {
        if (_usManager._conversationFinished)
        {
            switch (fukidasiNum)
            {
                case 0:

                    _eDamage._damageCount++;
                    break;
                case 1:
                    _eDamage._damageCount++;
                    break;
                case 2:
                    _eDamage._damageCount++;
                    break;
                case 3:
                    _eDamage._damageCount++;
                    break;
                case 4:
                    _eDamage._damageCount++;
                    break;
            }
        }
    }
}
