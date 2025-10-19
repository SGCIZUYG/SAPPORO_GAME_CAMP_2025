using UnityEngine;

public class ModelController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Model;

    private GameObject CurrentModel;
    private uint CurrentModelIdx;

    void Start()
    {
        CurrentModelIdx = 0;
        CurrentModel = Model[CurrentModelIdx];
    }

    private void UpdateModel()
    {
        CurrentModel.SetActive(false);
        CurrentModel = Model[CurrentModelIdx];
        CurrentModel.SetActive(true);
    }

    public void ToNextAnimation()
    {
        CurrentModelIdx++;
        if (CurrentModelIdx >= 3)
        {
            CurrentModelIdx = 0;
        }

        UpdateModel();
    }

    public void ResetAnimation()
    {
        CurrentModelIdx = 0;

        UpdateModel();
    }
}
