using UnityEngine;

public class SE_Manager : MonoBehaviour
{
    // Inspectorから設定するAudio Source
    private AudioSource _audioSource;

    // Inspectorから設定するSEのAudio Clip
    [SerializeField] private AudioClip _clickSE = default;

    void Start()
    {
        // 自身のオブジェクトからAudio Sourceを取得
        _audioSource = GetComponent<AudioSource>();
    }

    // ボタンのクリックイベントから呼び出す公的な関数
    public void PlayClickSound()
    {
        // 設定されたAudio Clipを一度だけ再生する
        if (_audioSource != null && _clickSE != null)
        {
            _audioSource.PlayOneShot(_clickSE);
        }
    }
}