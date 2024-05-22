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

    }


    private void Start() {
        levelInfo.healthPoints = 3;
        levelInfo.hasObject = false;
        if(SceneManager.GetActiveScene().name == "SceneAccueil"){
            levelInfo.playerName = "";
            levelInfo.levelName = "";
        }
        
    }

    public void ContactWithEnemy(){
        levelInfo.healthPoints--;
        if(levelInfo.healthPoints <= 0){
            SceneManager.LoadScene("SceneLose");
        }  
    }

    public void TrashItemEvent() {
        levelInfo.nbrObjectsRemaining--;
        levelInfo.hasObject=false;
    }
}
