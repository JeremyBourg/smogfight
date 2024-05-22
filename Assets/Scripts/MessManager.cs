using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessManager : MonoBehaviour
{

    [SerializeField]
    private LevelInfo levelInfo;

    [SerializeField]
    private List<GameObject> trashItems;

    [SerializeField]
    private TMP_Text textField;
    // Start is called before the first frame update
    void Start()
    {
        levelInfo.nbrObjectsCollectGoal = trashItems.Count;
        levelInfo.nbrObjectsRemaining = levelInfo.nbrObjectsCollectGoal;
        textField.text = "Objets restants: " + levelInfo.nbrObjectsRemaining;
    }

    public void UpdateText(){
        textField.text = "Objets restants: " + levelInfo.nbrObjectsRemaining;
    }
}
