using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

[System.Serializable]
public class Note_Move : MonoBehaviour
{
    public IObjectPool<GameObject> Pool { get; set; }
    public float NoteSpeed;

    [SerializeField]private int Note_number;

    private void Start()
    {
        NoteSpeed = Gamemanager.Instance.Note_Speed;
        this.gameObject.transform.Translate(new Vector3(0, ManagerMent.instance.offset * NoteSpeed , 0));
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -NoteSpeed);
    }

}
