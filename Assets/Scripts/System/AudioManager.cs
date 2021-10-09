using System;
using UnityEngine;
using System.Linq;

public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
    private const string BGM_PATH = "Audio/BGM/";
    private const string SE_PATH = "Audio/SE/";
    public const float BGM_FADE_SPEED_RATE = 0.9f;
    private float bgmFadeSpeedRate = BGM_FADE_SPEED_RATE;
    private bool isFadeOut = false;
    
    private AudioSource audioSourceForBGM;
    private AudioSource[] audioSourceForSEList = new AudioSource[20];


    protected override void Awake()
    {
        base.Awake();

        audioSourceForBGM = gameObject.AddComponent<AudioSource>();
        for (var i = 0; i < audioSourceForSEList.Length; ++i)
        {
            audioSourceForSEList[i] = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Update()
    {
	    
    }

    private AudioSource GetUnusedAudioSource() => audioSourceForSEList.FirstOrDefault(t => t.isPlaying == false);

    public void Play(AudioClip clip)
    {
        audioSourceForBGM.clip = clip;
        audioSourceForBGM.Play();
    }

    public void Play(String fileName)
    {
        AudioClip clip = Resources.Load<AudioClip>(BGM_PATH + fileName);
        if (clip == null)
        {
            Debug.LogWarning("指定されたファイルが見つかりません。");
            return;
        }
        Play(clip);
    }
    
    public void PlayOneShot(AudioClip clip)
    {
        var audioSource = GetUnusedAudioSource();
        if (audioSource == null)
        {
            Debug.Log("再生できませんでした。");
            return;
        }

        audioSource.clip = clip;
        audioSource.PlayOneShot(clip);
    }

    public void PlayOneShot(String fileName)
    {
        AudioClip clip = Resources.Load<AudioClip>(SE_PATH + fileName);
        if (clip == null)
        {
            Debug.LogWarning("指定されたファイルが見つかりません。");
            return;
        }
        PlayOneShot(clip);
    }
}
