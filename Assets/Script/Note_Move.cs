using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Note_Move : MonoBehaviour
{

    public float NoteSpeed;

    [SerializeField]private int Note_number;

    private void Start()
    {
        NoteSpeed = Gamemanager.Instance.Note_Speed;
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -NoteSpeed);
    }

}
