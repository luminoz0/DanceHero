using UnityEngine;
using UnityEngine.Events;

public class NoteLimits : MonoBehaviour
{
 [SerializeField]
 private UnityEvent onNotesLimitReached;
 private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Note"))
        {
            onNotesLimitReached?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
