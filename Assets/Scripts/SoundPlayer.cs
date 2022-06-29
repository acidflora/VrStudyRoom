using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SoundPlayer : MonoBehaviour
{
    [SerializeField] protected AudioClip[] sounds;
    protected AudioSource audioSource;

    protected void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void StopSoundPlayer()
    {
        audioSource.Stop();
    }
    public void PlaySound(string sound)
    {
      AudioClip clip = sounds.FirstOrDefault(p => p.name == sound);
        if (clip != null)
        {
            StopSoundPlayer();
            audioSource.PlayOneShot(clip);
        }
        else Debug.Log("Sound not found");
    }
}