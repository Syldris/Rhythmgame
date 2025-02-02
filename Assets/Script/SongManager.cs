using UnityEngine;
using System.Collections;

public class SongManager : MonoBehaviour
{
    public SongData currentSong; // 현재 선택된 곡의 ScriptableObject
    private AudioSource audioSource;
    private Note_instantiate noteInstantiate;
    private bool isPlaying = false;
    private float songTime; // 현재 곡의 재생 시간

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentSong.PrintSongInfo();
    }

    public void StartSong()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            audioSource.clip = currentSong.songClip;  
            audioSource.Play();                   
            StartCoroutine(SpawnNotes());          
        }
    }

    public void StopSong()
    {
        if (isPlaying)
        {
            isPlaying = false;
            audioSource.Stop();                      
            StopCoroutine(SpawnNotes());          
        }
    }

    private IEnumerator SpawnNotes()
    {
        int noteIndex = 0; // 생성할 노트 인덱스

        while (isPlaying && noteIndex < currentSong.noteDataList.Count)
        {
            songTime = audioSource.time; // 현재 곡의 재생 시간

            // 곡의 재생 시간과 노트 생성 타이밍을 비교하여 노트 생성
            if (songTime >= currentSong.noteDataList.Count)
            {
                // 노트 생성
                noteInstantiate.Ins_Note();
                noteIndex++;
            }

            yield return null; 
        }
    }
}


