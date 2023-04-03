using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboSuccess : MonoBehaviour {
    
    private int comboCounter;
    private bool wasSuccess;
    private bool enemyHitCheck;
    private bool attackOrderCheck;
    private bool phaseCheck;
    private string lastAttackType;

    [SerializeField] private WeaponCollision weaponCollision;
    [SerializeField] private PlayerAttack playerAttack;
    [SerializeField] private ComboPhase comboPhase;
    
    private void Start() {
        weaponCollision.Event += HandleEnemyHit;
        playerAttack.Event += HandleAttackOrder;
    }

    private void OnDestroy() {
        
        weaponCollision.Event -= HandleEnemyHit;
        playerAttack.Event -= HandleAttackOrder;
        
    }


    private void HandleEnemyHit() {


        enemyHitCheck = true;
        checkAllDone();
    }

    private void HandleAttackOrder(string attackType) {


        attackOrderCheck = true;
        checkAllDone();
        
    }
    

    private void HandleAttackInTime(int phase) {


        phaseCheck = true;
        checkAllDone();
    }
    
    private void checkAllDone() {
        if (phaseCheck && enemyHitCheck && attackOrderCheck) {
            phaseCheck = false;
            enemyHitCheck = false;
            attackOrderCheck = false;
        }
        CheckComboSuccess();
    }

    private void CheckComboSuccess() {
        
        
    }


}
