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
    private bool _fukidasiTap1 = false;
    private bool _fukidasiTap2 = false;
    private bool _fukidasiTap3 = false;
    private bool _fukidasiTap4 = false;
    private bool _fukidasiTap5 = false;

    List<string> word_1 = new List<string> { "ほら、「資料の提出が遅れてる」「チェックが甘い」って、何度言ったらわかるんだ。君は本当に使えないな。", "ほら、「資料の提出が遅れてる」「チェックが甘い」って、何度言ったらわかるんだ。君は本当に使えないな。", "ほら、「資料の提出が遅れてる」「チェックが甘い」って、何度言ったらわかるんだ。君は本当に使えないな。" };
    List<string> word_2 = new List<string> { "それからな、君にはちょっと“特別な任務”を任せる。来月のプロジェクトの資料を全部作り直してもらう。休日出勤も前提で、他のメンバーは手を貸さない。君ならできるだろ？", "それからな、君にはちょっと“特別な任務”を任せる。来月のプロジェクトの資料を全部作り直してもらう。休日出勤も前提で、他のメンバーは手を貸さない。君ならできるだろ？", "それからな、君にはちょっと“特別な任務”を任せる。来月のプロジェクトの資料を全部作り直してもらう。休日出勤も前提で、他のメンバーは手を貸さない。君ならできるだろ？" };
    List<string> word_3 = new List<string> { "準備時間？そんなもの言い訳だ。君くらいの役職なら、そんなの当たり前でしょ。じゃあ、やれないなら代わり探すけど。どうする？", "準備時間？そんなもの言い訳だ。君くらいの役職なら、そんなの当たり前でしょ。じゃあ、やれないなら代わり探すけど。どうする？", "準備時間？そんなもの言い訳だ。君くらいの役職なら、そんなの当たり前でしょ。じゃあ、やれないなら代わり探すけど。どうする？" };
    List<string> word_4 = new List<string> { "あとさ、昨日の飲み会で君、あまり発言なかったけど何を考えてたの？いつもぼーっとしてるだけじゃ、チームにも迷惑かかるんだよ。もっと積極的に意見出せるようになった方がいい。君のそれじゃ、将来どうなるか分からないからな。", "あとさ、昨日の飲み会で君、あまり発言なかったけど何を考えてたの？いつもぼーっとしてるだけじゃ、チームにも迷惑かかるんだよ。もっと積極的に意見出せるようになった方がいい。君のそれじゃ、将来どうなるか分からないからな。", "あとさ、昨日の飲み会で君、あまり発言なかったけど何を考えてたの？いつもぼーっとしてるだけじゃ、チームにも迷惑かかるんだよ。もっと積極的に意見出せるようになった方がいい。君のそれじゃ、将来どうなるか分からないからな。" };
    List<string> word_5 = new List<string> { "いいか、君はこの会社で“若手のホープ”なんだから。期待してるからこそ厳しく言ってるんだ。逃げるな、ちゃんとついてこい。分かったな？", "いいか、君はこの会社で“若手のホープ”なんだから。期待してるからこそ厳しく言ってるんだ。逃げるな、ちゃんとついてこい。分かったな？", "いいか、君はこの会社で“若手のホープ”なんだから。期待してるからこそ厳しく言ってるんだ。逃げるな、ちゃんとついてこい。分かったな？" };
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
                if (_fukidasiTap1 == true)
                {
                    _eDamage._damageCount++;
                    count += 1;
                }
                break;
            case 2:
                if (_fukidasiTap2 == true)
                {
                    _eDamage._damageCount++;
                    count += 1;
                }

                break;
            case 3:
                if (_fukidasiTap3 == true)
                {
                    _pDamage._damageCount += 3;

                }

                break;
            case 4:
                if (_fukidasiTap4 == true)
                {
                    _eDamage._damageCount++;
                    count += 1;
                }

                break;
            case 5:
                if (_fukidasiTap5 == true)
                {
                    _pDamage._damageCount += 3;

                }

                break;
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
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap1 = true;

                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_1[1];
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap1 = true;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_1[2];
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap1 = true;
                    }

                    break;

                case 1:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_2[0];
                        _fukidasiTap1 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap2 = true;
                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_2[1];
                        _fukidasiTap1 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap2 = true;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_2[2];
                        _fukidasiTap1 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap2 = true;
                    }

                    break;

                case 2:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_3[0];

                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap3 = true;

                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_3[1];

                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap3 = true;

                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_3[2];

                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap3 = true;

                    }

                    break;

                case 3:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_4[0];
                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap4 = true;
                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_4[1];
                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap4 = true;
                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_4[2];
                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap5 = false;
                        _fukidasiTap4 = true;
                    }

                    break;

                case 4:
                    if (count == 1)
                    {
                        _mainTextObject.text = word_5[0];

                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = true;

                    }
                    else if (count == 2)
                    {
                        _mainTextObject.text = word_5[1];

                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = true;

                    }
                    else if (count == 3)
                    {
                        _mainTextObject.text = word_5[2];

                        _fukidasiTap1 = false;
                        _fukidasiTap2 = false;
                        _fukidasiTap3 = false;
                        _fukidasiTap4 = false;
                        _fukidasiTap5 = true;

                    }

                    break;
            }
        }
    }
}
