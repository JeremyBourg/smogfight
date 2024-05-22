using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SignUpdate : MonoBehaviour
{
    [SerializeField] 
    private LevelInfo levelInfo;

    [SerializeField] 
    private TMP_Text levelName;

    private void Start() {
        levelName.text = "Centre pétrolier " + levelInfo.levelName;
    }
}
