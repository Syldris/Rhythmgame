using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Sound : MonoBehaviour
{
    public VideoPlayer player;
    public float sound_song;
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        player.SetDirectAudioVolume(0, ManagerMent.instance.BGM * sound_song);
    }
}
