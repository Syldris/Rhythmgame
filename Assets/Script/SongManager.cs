using UnityEngine;
using System.Collections;

public class SongManager : MonoBehaviour
{
    public SongData currentSong; // ���� ���õ� ���� ScriptableObject
    private AudioSource audioSource;
    private Note_instantiate noteInstantiate;
    private bool isPlaying = false;
    private float songTime; // ���� ���� ��� �ð�

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
        int noteIndex = 0; // ������ ��Ʈ �ε���

        while (isPlaying && noteIndex < currentSong.noteDataList.Count)
        {
            songTime = audioSource.time; // ���� ���� ��� �ð�

            // ���� ��� �ð��� ��Ʈ ���� Ÿ�̹��� ���Ͽ� ��Ʈ ����
            if (songTime >= currentSong.noteDataList.Count)
            {
                // ��Ʈ ����
                noteInstantiate.Ins_Note();
                noteIndex++;
            }

            yield return null; 
        }
    }
}


