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
        // �N���b�N���ꂽ�Ƃ��A���̍s�ֈړ�
        if (Input.GetMouseButtonUp(0))
        {
            GoToTheNextLine();
            DisplayText();                      
        }
        //�N���b�N���ꂽ�Ƃ��A��ʂɉ�ʐ^����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            obj.SetActive(true);
        }
    }

    // ���̍s�ֈړ�
    public void GoToTheNextLine()
    {
        GameManager.Instance.lineNumber++;
    }

    // �e�L�X�g��\��
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
