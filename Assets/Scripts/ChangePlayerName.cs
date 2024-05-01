using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangePlayerName : MonoBehaviour
{
    public LevelInfo levelInfo;
    public TMP_Text playerNameText;
    public TMP_Text levelNameText;
    void Start()
    {
        playerNameText.text = levelInfo.playerName;
        levelNameText.text = levelInfo.levelName;
    }
}
