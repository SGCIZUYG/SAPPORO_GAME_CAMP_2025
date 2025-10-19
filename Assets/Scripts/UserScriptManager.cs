using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UserScriptManager : MonoBehaviour
{
    [SerializeField] TextAsset _textFile;
    public bool _conversationFinished = false;
    // ���͒��̕��i�����ł͂P�s���Ɓj�����Ă������߂̃��X�g
    List<string> _sentences = new List<string>();

    void Awake()
    {
        // �e�L�X�g�t�@�C���̒��g���A�P�s�����X�g�ɓ���Ă���
        StringReader reader = new StringReader(_textFile.text);
        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            _sentences.Add(line);
        }
    }

    // ���݂̍s�̕����擾����
    public string GetCurrentSentence()
    {
        if (GameManager.Instance.lineNumber >= _sentences.Count)
        {
            _conversationFinished = true;
            return "";
        }
        return _sentences[GameManager.Instance.lineNumber];
    }
}

