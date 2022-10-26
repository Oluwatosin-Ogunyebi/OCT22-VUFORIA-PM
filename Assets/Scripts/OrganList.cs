using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OrganList : MonoBehaviour
{
    [SerializeField] private Image brainImage, heartImage;
    [SerializeField] private TMP_Text infoText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnBrainFound()
    {
        Debug.Log("Brain is found");
        infoText.text = "Brain is found";
        brainImage.color = new Color(1, 1, 1, 1);
    }

    public void OnHeartFound()
    {
        Debug.Log("Heart is found");
        infoText.text = "Heart is found";
        heartImage.color = new Color(1, 1, 1, 1);
    }
}
