using UnityEngine;

[CreateAssetMenu(menuName = "SO/LevelInfo")]
public class LevelInfo : ScriptableObject
{
    public int nbrObjectsCollectGoal;
    public int nbrObjectsCollected;
    public int score;
    public int timeLimitInSeconds;
    public string levelName;
    public string playerName;
    public AudioClip music;
}