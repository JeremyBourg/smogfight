using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseManager : MonoBehaviour
{
    [SerializeField]
    private LevelInfo levelInfo;

    [SerializeField]
    private TMP_Text textObjectsLeft;

    private void Start() {
        textObjectsLeft.text = "Il vous restait " + levelInfo.nbrObjectsRemaining + " objets à ramasser";
    }

    public void RestartGame(){
        SceneManager.LoadScene("SceneAccueil");
    }
}
