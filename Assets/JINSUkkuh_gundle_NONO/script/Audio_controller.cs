using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Audio_controller : MonoBehaviour
{
    [SerializeField] private AudioMixer m_AudioMixer;
    [SerializeField] private Slider m_MusicMasterSlider;
    [SerializeField] private Slider m_MusicBGMSlider;
    [SerializeField] private Slider m_MusicSFXSlider;
    [SerializeField] private Slider m_MusicSkill_VoiceSlider;

    private void Awake()
    {
        //m_MusicMasterSlider.onValueChanged.AddListener(SetMasterVolume);
        m_MusicBGMSlider.onValueChanged.AddListener(SetBGMVolume);
        m_MusicSFXSlider.onValueChanged.AddListener(SetSFXVolume);
        m_MusicSkill_VoiceSlider.onValueChanged.AddListener(SetSkill_VoiceVolume);
    }

    public void SetMasterVolume(float volume)
    {
        m_AudioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
    }

    public void SetBGMVolume(float volume)
    {
        m_AudioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
    }

    public void SetSFXVolume(float volume)  
    {
        m_AudioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }

    public void SetSkill_VoiceVolume(float volume)
    {
        m_AudioMixer.SetFloat("Skill_Voice", Mathf.Log10(volume) * 20);
    }
}
