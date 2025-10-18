using UnityEngine;

public class HPLost : MonoBehaviour
{
    [SerializeField] private int _hpNum = 0;
    [SerializeField] private PlayerDamage _pDmagage = default;
    private SpriteRenderer _sp = default;

    private void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if(_pDmagage._damageCount == _hpNum)
        {
            _sp.color = Color.black;
        }
    }
}
