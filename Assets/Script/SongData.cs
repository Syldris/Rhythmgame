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

    [Header("�� Ÿ�̹�")]
    public List<NoteData> noteDataList = new List<NoteData>();

    [System.Serializable]
    public class NoteData
    {
        public float time;        // ��Ʈ�� �������� �ð�
        public int line;         // ��Ʈ�� �������� ���� 
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
        Debug.Log("������: " + songTitle);
        Debug.Log("����: " + artistName);
        Debug.Log("BPM: " + bpm);
        Debug.Log("���̵�: " + difficulty);
    }
}

