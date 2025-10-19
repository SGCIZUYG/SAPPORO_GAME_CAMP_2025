using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int _damageCount = 0;

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _damageCount++;
        }
    }
}
