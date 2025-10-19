using UnityEngine;

public class SE_Manager : MonoBehaviour
{
    // Inspector����ݒ肷��Audio Source
    private AudioSource _audioSource;

    // Inspector����ݒ肷��SE��Audio Clip
    [SerializeField] private AudioClip _clickSE = default;

    void Start()
    {
        // ���g�̃I�u�W�F�N�g����Audio Source���擾
        _audioSource = GetComponent<AudioSource>();
    }

    // �{�^���̃N���b�N�C�x���g����Ăяo�����I�Ȋ֐�
    public void PlayClickSound()
    {
        // �ݒ肳�ꂽAudio Clip����x�����Đ�����
        if (_audioSource != null && _clickSE != null)
        {
            _audioSource.PlayOneShot(_clickSE);
        }
    }
}