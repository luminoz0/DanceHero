using UnityEngine;
using UnityEngine.Events;
public class SoungManager : MonoBehaviour
{
     [SerializeField]
     private Animator characterAnimator;
     [SerializeField]
     private UnityEvent onSongStart;
     [SerializeField]
     private UnityEvent onSongEnd;
     
     public void PlaySong(SoundData soundData)
    {
        characterAnimator.Play(soundData.animationName);
        SoundManager.instance.PlayMusic(soundData.songName);
        onSongStart?.Invoke();
    }
    public void StopSong()
    {
        SoundManager.instance.StopMusic();
        onSongEnd?.Invoke();
    }

}
