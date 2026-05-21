using UnityEngine;

public class Lane : MonoBehaviour
{
   [SerializeField]
   private Transform notePivot;
   [SerializeField]
   private GameObject notePrefab;
   public Transform NotesPivot => notePivot;
   public GameObject NotePrefab => notePrefab;

}
