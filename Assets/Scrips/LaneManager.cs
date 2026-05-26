using UnityEngine;

public class LaneManager : MonoBehaviour
{
    [SerializeField]
    private string showAnimacionName = "Show";
     [SerializeField]
    private string hideAnimacionName = "Hide";
    [SerializeField]
    private Lane[] lanes;
    [SerializeField]
    private Animator animator;
    private bool isHidden = true;
    public Lane GetLane(int index)
    {
        if(index < 0 || index >= lanes.Length)
        {
            Debug.LogWarning("Lane index out of range:" + index);
            return lanes[0];
        }
        return lanes[index];
    }
    public int GetLaneCount()
    {
        return lanes.Length;
    }
    public void ShowLane()
    {
        animator.Play(showAnimacionName);
        isHidden = false;
    }
    public void HideLane()
    {
        if(isHidden) return;
        animator.Play(hideAnimacionName);
        isHidden = true;
    }
}
