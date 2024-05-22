using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccueilManager : MonoBehaviour
{

    
    [SerializeField]
    private LevelInfo levelInfo;

    public void UpdatePlayerName(string inputPlayerName){
        levelInfo.playerName = inputPlayerName;
    }

    public void UpdateLevelName(string inputLevelName){
        levelInfo.levelName = inputLevelName;
    }

    public void LoadSceneNiveau(){
        if(levelInfo.levelName != "" && levelInfo.playerName != ""){
            SceneManager.LoadScene("SceneNiveau");
        }
        else{
            SendInputError();
        } 
    }

    // Change placeholder on attempt to load scene with empty field
    // bonus: si temps libre, essayer de faire l'écran shaker.
    private void SendInputError(){
        Debug.Log("Field cannot be empty");
    }

    void Start()
    {
        levelInfo.playerName = "";
        levelInfo.levelName = "";
    }
}
