using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangePlayerName : MonoBehaviour
{
    public LevelInfo levelInfo;
    public TMP_Text playerNameText;
    void Start()
    {
        playerNameText.text = levelInfo.playerName;
    }
}
