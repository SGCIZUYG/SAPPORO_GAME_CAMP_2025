using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MainTextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _mainTextObject;
    //[SerializeField] TextMeshProUGUI _mainTextNameObject;
    [SerializeField] GameObject obj;
    public bool stopDisplayFunction;

    void Start()
    {
        stopDisplayFunction = false;
        DisplayText();
    }


    void Update()
    {
        // クリックされたとき、次の行へ移動
        if (Input.GetMouseButtonUp(0))
        {
            GoToTheNextLine();
            DisplayText();                      
        }
        //クリックされたとき、画面に画面真っ白
        if (Input.GetKeyDown(KeyCode.Space))
        {
            obj.SetActive(true);
        }
    }

    // 次の行へ移動
    public void GoToTheNextLine()
    {
        GameManager.Instance.lineNumber++;
    }

    // テキストを表示
    public void DisplayText()
    {
        if (!stopDisplayFunction)
        {
            string sentence = GameManager.Instance.userScriptManager.GetCurrentSentence();
            _mainTextObject.text = sentence;
        }
        //_mainTextNameObject.text = sentence;
    }
}
