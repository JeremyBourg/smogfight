using UnityEngine;

[CreateAssetMenu(menuName = "SO/LevelInfo")]
public class LevelInfo : ScriptableObject
{
    public int nbrObjectsCollectGoal;
    public int nbrObjectsRemaining;
    public int healthPoints;
    public float timeRemaining;
    public int timeLimitInSeconds;
    public string levelName;
    public string playerName;
    public bool hasObject = false;
    public AudioClip music;
}