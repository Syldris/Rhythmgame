using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    [SerializeField] bool self_target;
    [SerializeField] SpriteRenderer sprite_target;
    [SerializeField] Sprite[] sprite_ani;
    [SerializeField] float time; // 외부적인 시간요소가 들어오면 배제
    [SerializeField] float waitTime;

    [SerializeField] float delayTime;
    int reset_count = 0;

    private void Start()
    {
        StartCoroutine(Effect());

        if (sprite_ani.Length == 0)
        {
            //Log.Warning($"Empty ani array in {gameObject.name}");
            enabled = false;
            return;
        }

        if (self_target)
        {
            sprite_target = GetComponent<SpriteRenderer>();
        }

        Invoke("OnTimerEnd", delayTime); // 외부적인 시간요소가 들어오면 배제
    }

    //
    private void OnTimerEnd()
    {
        if (reset_count < sprite_ani.Length)
        {
            sprite_target.sprite = sprite_ani[reset_count];
            reset_count++;
        }
        else
        {
            reset_count = 0;
            sprite_target.sprite = sprite_ani[reset_count];
            reset_count++;
        }
        if (reset_count == sprite_ani.Length)
        {
            Invoke("OnTimerEnd", time + waitTime); // 외부적인 시간요소가 들어오면 배제
        }
        else
        {
            Invoke("OnTimerEnd", time); // 외부적인 시간요소가 들어오면 배제
        }
    }

    IEnumerator Effect()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(this.gameObject);
    }
}