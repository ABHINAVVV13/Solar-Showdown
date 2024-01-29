using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBar : MonoBehaviour
{
    [Header("UI References :")]
    [SerializeField] private Image uiFillImage;

    public ScoreController scoreController;
    
    public void Start()
    {
         uiFillImage.fillAmount = 0.5f;

    }
    public void Update()
    {
        double rate = scoreController.score * 0.05;
        uiFillImage.fillAmount = (float)rate;
       
    }


}
