using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPHUD : MonoBehaviour
{
    public List<Image> heartImages;
    private int currentHealth;

    void Start()
    {
        currentHealth = heartImages.Count;
        ResetHealth();
    }

    public void LoseHeart()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            heartImages[currentHealth].enabled = false;
        }
    }

    public void ResetHealth()
    {
        currentHealth = heartImages.Count;
        foreach (Image heart in heartImages)
        {
            heart.enabled = true;
        }
    }
}
