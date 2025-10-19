using System.Collections.Generic;
using TMPro;
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
    [SerializeField] private PlayerDamage _pDamage = default;
    [SerializeField] TextMeshProUGUI _mainTextObject;
    [SerializeField] MainTextController _mainTextController;
    private UserScriptManager _usManager = default;

    List<string> word_1 = new List<string> { "君は本当に使えないな。", "君は本当に使えないな。", "君は本当に使えないな。" };
    List<string> word_2 = new List<string> { "休日出勤も前提で、他のメンバーは手を貸さない。君ならできるだろ？", "来月のプロジェクトの資料を全部作り直してもらう。休日出勤も前提で、他のメンバーは手を貸さない。", "来月のプロジェクトの資料を全部作り直してもらう。休日出勤も前提で、他のメンバーは手を貸さない。" };
    List<string> word_3 = new List<string> { "じゃあ、やれないなら代わり探すけど。どうする？", "じゃあ、やれないなら代わり探すけど。どうする？", "じゃあ、やれないなら代わり探すけど。どうする？" };
    List<string> word_4 = new List<string> { "君のそれじゃ、将来どうなるか分からないからな。", "君のそれじゃ、将来どうなるか分からないからな。", "君のそれじゃ、将来どうなるか分からないからな。" };
    List<string> word_5 = new List<string> { "逃げるな、ちゃんとついてこい。分かったな？", "逃げるな、ちゃんとついてこい。分かったな？", "逃げるな、ちゃんとついてこい。分かったな？" };
    int count;

    private void Start()
    {
        _fukidasi1.SetActive(false);
        _fukidasi2.SetActive(false);
        _fukidasi3.SetActive(false);
        _fukidasi4.SetActive(false);
        _fukidasi5.SetActive(false);
        _usManager = GetComponent<UserScriptManager>();
        count = 1;
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

    public void OnClick(int click)
    {
        switch (click)
        {
            case 1:
                _eDamage._damageCount++;
                break;
            //case 2:
            //    _eDamage._damageCount++;
            //    break;
            //case 3:
            //    _pDamage._damageCount += 3;
            //    break;
            //case 4:
            //    _eDamage._damageCount++;
            //    break;
            //case 5:
            //    _pDamage._damageCount += 3;
            //    break;
        }
    }
    public void OnFukidasiSelect(int fukidasiNum)
    {
        _mainTextController.stopDisplayFunction = true;

        if (_usManager._conversationFinished)
        {
            switch (fukidasiNum)
            {
                case 0:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_1[0];
                        count++;
                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_1[1];
                        count++;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_1[2];
                        count++;
                    }
                  
                    break;

                case 1:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_2[0];
                        count++;
                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_2[1];
                        count++;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_2[2];
                        count++;
                    }
                 
                    break;

                case 2:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_3[0];
                        count++;
                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_3[1];
                        count++;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_3[2];
                        count++;
                    }
                  
                    break;

                case 3:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_4[0];
                        count++;
                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_4[1];
                        count++;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_4[2];
                        count++;
                    }
               
                    break;

                case 4:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_5[0];
                        count++;
                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_5[1];
                        count++;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_5[2];
                        count++;
                    }
                  
                    break;
            }
        }
    }
}
