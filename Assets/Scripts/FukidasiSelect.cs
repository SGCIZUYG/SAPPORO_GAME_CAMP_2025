using UnityEngine;

public class FukidasiSelect : MonoBehaviour
{
    [SerializeField] private GameObject _fukidasi1 = default;
    [SerializeField] private GameObject _fukidasi2 = default;
    [SerializeField] private GameObject _fukidasi3 = default;
    [SerializeField] private GameObject _fukidasi4 = default;
    [SerializeField] private GameObject _fukidasi5 = default;

    public void OnFukidasiSelect(int fukidasiNum)
    {
        switch (fukidasiNum)
        {
            case 0:
                _fukidasi1.SetActive(true);
                break;
            case 1:
                _fukidasi2.SetActive(true); 
                break;
        }
    }
}
