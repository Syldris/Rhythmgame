using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public RaycastHit2D hit;
    float MaxDistance = 5f;


    private void Start()
    {
        
    }

    private void Update()
    {
        hit = Physics2D.Raycast(new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Vector2.down, MaxDistance);
        Debug.DrawRay(transform.position, new Vector3(0, -MaxDistance, 0),Color.red);
        if (hit.collider != null)
        {
            for(int i =0; i<7; i++)
            {
                this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < 7; i++)
            {
                this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

    }
}
