using UnityEngine;
using UnityEngine.Events;
public class SoungManager : MonoBehaviour
{
     [SerializeField]
     private Animator characterAnimator;
     [SerializeField]
     private UnityEvent onSongStart;
     [SerializeField]
     private UnityEvent onSongSelected;
     [SerializeField]
     private UnityEvent onSongEnd;
     private SoundData currentSongData;
     public void SelectSong(SoundData soundData)
    {
       currentSongData = soundData;
        onSongSelected?.Invoke();
    }
    public void StopSong()
    {
        SoundManager.instance.StopMusic();
        onSongEnd?.Invoke();
    }
    public void StartSong()
    {
         characterAnimator.Play(currentSongData.animationName);
        SoundManager.instance.PlayMusic(currentSongData.songName);
        onSongStart?.Invoke();
    }

}
