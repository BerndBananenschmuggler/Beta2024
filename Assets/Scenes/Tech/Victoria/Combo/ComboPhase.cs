using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboPhase : MonoBehaviour
{
    [SerializeField] private ComboStatsSO comboStats;
    
    //private ComboAttack comboAttack;

    private string lastAttack = "";

    private float timeLastAttack;

    public event Action<string> comboPhaseUI;

    private float[] phases = {0,0,0,0,0};

    /*private void Awake()
    {
        comboAttack = GetComponent<ComboAttack>();
    }

    private void Start()
    {
        comboAttack.OnAttack += HandleAttack;
        
    }

    private void OnDestroy()
    {
        comboAttack.OnAttack -= HandleAttack;
    }*/

    //Aufgerufen über OnAttack event
    //Prüfe ob Attack Combo erfolgreich
    private void HandleAttack(string attackType, float cooldown)
    {
        if (attackType != lastAttack && cooldown <= comboStats.comboCooldown)
        {
            lastAttack = attackType;

            HandlePhase(cooldown);
        }
    }

    
    //vergleicht mit den Phasen-Zeiten und invoked event mit passenden Schlüsselwort
    private void HandlePhase(float cooldown)
    {
        if (cooldown < phases[0])
        {
            comboPhaseUI?.Invoke("fail");
        }

        if (cooldown < phases[1])
        {
            comboPhaseUI?.Invoke("fast");
        }
            
        if (cooldown < phases[2])
        {
            comboPhaseUI?.Invoke("perfekt");
        }
            
        if (cooldown < phases[3])
        {
            comboPhaseUI?.Invoke("knapp");
        }
            
        if (cooldown < phases[4])
        {
            comboPhaseUI?.Invoke("mies");
        }
    }

    private void PhasesConverter()
    {
        phases[0] = comboStats.comboCooldown * comboStats.phaseOne;
        phases[1] = comboStats.comboCooldown * comboStats.phaseTwo + phases[0];
        phases[2] = comboStats.comboCooldown * comboStats.phaseThree + phases[1];
        phases[3] = comboStats.comboCooldown * comboStats.phaseFour + phases[2];
        phases[4] = comboStats.comboCooldown * comboStats.phaseFive + phases[3];
    }
}
