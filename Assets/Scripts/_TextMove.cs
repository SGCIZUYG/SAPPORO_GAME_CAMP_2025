using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _TextMove : MonoBehaviour
{
    [SerializeField] public TextMeshPro text;
    [SerializeField] Text sei_1;
    [SerializeField] Text sei_2;
    [SerializeField] Text sei_3;


    void Start()
    {
        text = GetComponent<TextMeshPro>();
        sei_1 = GetComponent<Text>();
        sei_2 = GetComponent<Text>();
        sei_3 = GetComponent<Text>();
    }

     void ButtonClick()
    {

        if(text == sei_1 || text == sei_2 || text == sei_3)
        {
            //ê¨å˜ÇµÇΩÇÁ
        }
        else
        {
            //é∏îsÇµÇΩÇÁ
        }
    }


}
