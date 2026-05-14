using UnityEngine;
using System.Collections;
public class ButtonsManager : MonoBehaviour
{
    [SerializeField]
    private Animator[] songButtons;
    [SerializeField]
    private Animator closeButton;
    [SerializeField]
    private float timeBetweenButtons = 0.1f;
    [SerializeField]
    private string showAnimatonName = "Show";
    [SerializeField]
    private string hideAnimationName = "Hide";
    public void ShowSongButtons()
    {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(showAnimatonName));
    }
    public void HideSongButtons()
    {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(hideAnimationName));
    }
    private IEnumerator AnimateButtons(string animationName)
    {
        foreach(Animator button in songButtons)
        {
            button.Play(animationName);
            yield return new WaitForSeconds(timeBetweenButtons);
        }
    }
    public void ShowCloseButton()
    {
        closeButton.Play(showAnimatonName);
    }
    public void HideCloseButton()
    {
        closeButton.Play(hideAnimationName);
    }


}
