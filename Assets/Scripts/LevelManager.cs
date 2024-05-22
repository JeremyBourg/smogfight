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


    private void Start() {
        levelInfo.healthPoints = 3;
        levelInfo.hasObject = false;
    }

    public void ContactWithEnemy(){
        levelInfo.healthPoints--;
        if(levelInfo.healthPoints <= 0){
            GameEnd();
        }  
    }

    public void TrashItemEvent() {
        levelInfo.hasObject=false;
    }

    public void GameEnd() {
        if(levelInfo.nbrObjectsRemaining <= 0) {
            SceneManager.LoadScene("SceneWin");
        }
        else{
            SceneManager.LoadScene("SceneLose");
        }
    }
}
