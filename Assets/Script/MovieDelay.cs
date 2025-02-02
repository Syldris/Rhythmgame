using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieDelay : MonoBehaviour
{
    public VideoPlayer player;
    void Start()
    {
        player = GetComponent<VideoPlayer>();

        StartCoroutine(VideoDelay());
    }
    IEnumerator VideoDelay()
    {
        player.Prepare();
        while (!player.isPrepared)
        {
            yield return new WaitForEndOfFrame();
        }
        player.frame = 0; //just incase it's not at the first frame
        player.Play();
        yield break;
    }
}
