using UnityEngine;

public class PlayerHPLost : MonoBehaviour
{
    [SerializeField] private int _hpNum = 0;
    [SerializeField] private PlayerDamage _pDmageCount = default;
    private SpriteRenderer _sp = default;

    private void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (_pDmageCount._damageCount == _hpNum)
        {
            _sp.enabled = false;
            print("ƒ_ƒ[ƒW‚ğó‚¯‚½");
        }
    }
}
