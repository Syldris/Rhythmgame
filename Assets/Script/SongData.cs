using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSongData", menuName = "ScriptableObjects/SongData", order = 1)]
public class SongData : ScriptableObject
{
    public string songTitle; 
    public string artistName;
    public float difficulty;
    public float bpm;
    public AudioClip songClip; 

    [Header("곡 타이밍")]
    public List<NoteData> noteDataList = new List<NoteData>();

    [System.Serializable]
    public class NoteData
    {
        public float time;        // 노트가 떨어지는 시간
        public int line;         // 노트가 떨어지는 라인 
        public NoteType noteType; 
    }

    public enum NoteType
    {
        Normal, 
        Small, 
        Heal     
    }

    public void PrintSongInfo()
    {
        Debug.Log("곡제목: " + songTitle);
        Debug.Log("제작: " + artistName);
        Debug.Log("BPM: " + bpm);
        Debug.Log("난이도: " + difficulty);
    }
}

