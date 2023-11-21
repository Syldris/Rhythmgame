using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_instantiate : MonoBehaviour
{
    [SerializeField] private GameObject Note;
    public int instantiate_num;
    public float time;

    private void Update()
    {
        time += Time.deltaTime;

        if (time > 1.0f)
        {
            time = 0.0f;
            Noteinstantiate();
        }
    }
    void Noteinstantiate()
    {
        Instantiate(Note, this.gameObject.transform);

    }

}
