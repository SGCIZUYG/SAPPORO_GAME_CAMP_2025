using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private GameObject _cam = default;
    public int _damageCount = 0;
    private int _damageWaveCount = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _damageCount++;
            _damageWaveCount = 0;
            switch (_damageWaveCount)
            {
                case 0:
                    _cam.transform.position += transform.up * 0.5f + transform.right * -0.5f;
                    _damageWaveCount++;
                    break;
                case 1:
                    _cam.transform.position += transform.up * -0.5f + transform.right * 0.5f;
                    _damageWaveCount++;
                    break;
                case 2:
                    _cam.transform.position += transform.right * -1.0f;
                    _damageWaveCount++;
                    break;
                case 3:
                    _cam.transform.position += transform.right * 1.0f;
                    _damageWaveCount++;
                    break;
            }
        }
    }
}
