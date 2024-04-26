using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField]
    private LevelInfo levelInfo;

    public void PickUpObject(Component sender, object data){
        Debug.Log("Score: " + data);
        
        levelInfo.nbrObjectsCollected++;
    }

    public void UpdatePlayerName(string inputPlayerName){
        levelInfo.playerName = inputPlayerName;
    }

    public void UpdateLevelName(string inputLevelName){
        levelInfo.levelName = inputLevelName;
    }

    public void LoadSceneNiveau(){
        SceneManager.LoadScene("SceneNiveau");
    }
}
