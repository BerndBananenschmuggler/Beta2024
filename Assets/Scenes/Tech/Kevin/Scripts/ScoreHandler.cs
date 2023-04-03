using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour {
    [SerializeField] private TMP_Text score;
   // [SerializeField] private ComboSuccess comboSuccess;



    private void Start() {
        score = GetComponent<TMP_Text>();
    //    comboSuccess.Event += HandleComboUI();
    }

    private void HandleComboUI(int comboCounter) 
    {

        score.text = "Combo Score: " + comboCounter.ToString();
        
    }

    private void OnDestroy() {
    //    comboSuccess.Event -= HandleComboUI();
    }
}
