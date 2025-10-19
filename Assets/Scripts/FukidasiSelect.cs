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

    List<string> word_1 = new List<string> { "�ق�A�u�����̒�o���x��Ă�v�u�`�F�b�N���Â��v���āA���x��������킩��񂾁B�N�͖{���Ɏg���Ȃ��ȁB", "�ق�A�u�����̒�o���x��Ă�v�u�`�F�b�N���Â��v���āA���x��������킩��񂾁B�N�͖{���Ɏg���Ȃ��ȁB", "�ق�A�u�����̒�o���x��Ă�v�u�`�F�b�N���Â��v���āA���x��������킩��񂾁B�N�͖{���Ɏg���Ȃ��ȁB" };
    List<string> word_2 = new List<string> { "���ꂩ��ȁA�N�ɂ͂�����Ɓg���ʂȔC���h��C����B�����̃v���W�F�N�g�̎�����S����蒼���Ă��炤�B�x���o�΂��O��ŁA���̃����o�[�͎��݂��Ȃ��B�N�Ȃ�ł��邾��H", "���ꂩ��ȁA�N�ɂ͂�����Ɓg���ʂȔC���h��C����B�����̃v���W�F�N�g�̎�����S����蒼���Ă��炤�B�x���o�΂��O��ŁA���̃����o�[�͎��݂��Ȃ��B�N�Ȃ�ł��邾��H", "���ꂩ��ȁA�N�ɂ͂�����Ɓg���ʂȔC���h��C����B�����̃v���W�F�N�g�̎�����S����蒼���Ă��炤�B�x���o�΂��O��ŁA���̃����o�[�͎��݂��Ȃ��B�N�Ȃ�ł��邾��H" };
    List<string> word_3 = new List<string> { "�������ԁH����Ȃ��̌����󂾁B�N���炢�̖�E�Ȃ�A����Ȃ̓�����O�ł���B���Ⴀ�A���Ȃ��Ȃ����T�����ǁB�ǂ�����H", "�������ԁH����Ȃ��̌����󂾁B�N���炢�̖�E�Ȃ�A����Ȃ̓�����O�ł���B���Ⴀ�A���Ȃ��Ȃ����T�����ǁB�ǂ�����H", "�������ԁH����Ȃ��̌����󂾁B�N���炢�̖�E�Ȃ�A����Ȃ̓�����O�ł���B���Ⴀ�A���Ȃ��Ȃ����T�����ǁB�ǂ�����H" };
    List<string> word_4 = new List<string> { "���Ƃ��A����̈��݉�ŌN�A���܂蔭���Ȃ��������ǉ����l���Ă��́H�����ځ[���Ƃ��Ă邾������A�`�[���ɂ����f������񂾂�B�����ƐϋɓI�Ɉӌ��o����悤�ɂȂ������������B�N�̂��ꂶ��A�����ǂ��Ȃ邩������Ȃ�����ȁB", "���Ƃ��A����̈��݉�ŌN�A���܂蔭���Ȃ��������ǉ����l���Ă��́H�����ځ[���Ƃ��Ă邾������A�`�[���ɂ����f������񂾂�B�����ƐϋɓI�Ɉӌ��o����悤�ɂȂ������������B�N�̂��ꂶ��A�����ǂ��Ȃ邩������Ȃ�����ȁB", "���Ƃ��A����̈��݉�ŌN�A���܂蔭���Ȃ��������ǉ����l���Ă��́H�����ځ[���Ƃ��Ă邾������A�`�[���ɂ����f������񂾂�B�����ƐϋɓI�Ɉӌ��o����悤�ɂȂ������������B�N�̂��ꂶ��A�����ǂ��Ȃ邩������Ȃ�����ȁB" };
    List<string> word_5 = new List<string> { "�������A�N�͂��̉�ЂŁg���̃z�[�v�h�Ȃ񂾂���B���҂��Ă邩�炱�������������Ă�񂾁B������ȁA�����Ƃ��Ă����B���������ȁH", "�������A�N�͂��̉�ЂŁg���̃z�[�v�h�Ȃ񂾂���B���҂��Ă邩�炱�������������Ă�񂾁B������ȁA�����Ƃ��Ă����B���������ȁH", "�������A�N�͂��̉�ЂŁg���̃z�[�v�h�Ȃ񂾂���B���҂��Ă邩�炱�������������Ă�񂾁B������ȁA�����Ƃ��Ă����B���������ȁH" };
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
