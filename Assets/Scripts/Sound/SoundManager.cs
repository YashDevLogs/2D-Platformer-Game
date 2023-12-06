using System;
using UnityEngine;


public class SoundManager : MonoBehaviour
{

        private static SoundManager instance;
        public static SoundManager Instance { get { return instance; } }


    public bool IsMute = false;
    public float Volume = 1f;
    public AudioSource SoundEffect;
    public AudioSource SoundMusic;
    public SoundType[] Sounds;

    private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    private void Start()
    {
        playMusic(global::Sounds.Music);   
    }
    public void playMusic(Sounds sound)
    {
        if (IsMute)
            return;

        AudioClip clip = getSoundClip(sound);
        if (clip != null)
        {
            SoundMusic.clip = clip;
            SoundMusic.Play();
        }
        else
        {
            Debug.Log("clip not found: " + sound);
        }


    }

    public void play(Sounds sound)
    {
        if (IsMute)
            return;

        AudioClip clip = getSoundClip(sound);
        if (clip != null)
            SoundEffect.PlayOneShot(clip);
        else
        {
            Debug.Log("clip not found: " + sound); 
        }



    }

    public void Mute(bool status)
    {
        status = false;
    }

    public void SetVolume(float volume)
    {
        Volume = volume;
        SoundEffect.volume = Volume;
        SoundMusic.volume = Volume;
    }


    private AudioClip getSoundClip(Sounds sound)
    {
        SoundType item = Array.Find(Sounds, i => i.soundType == sound);
        if (item != null)
            return item.soundclip;
        return null;
        
       
    }
}


[Serializable]
public class SoundType
{
    public Sounds soundType;
    public AudioClip soundclip;
}

public enum Sounds
{
    ButtonClick,
    Music,
    PlayerMove,
    PlayerDeath,
    EnemyDeath
}