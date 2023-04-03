using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboAttack : MonoBehaviour
{

    private float _timeSinceLastAttack;

    private string _lastAttack;

    private float _lastAttackTime;

    public event Action<float> OnComboTime;
    // Start is called before the first frame update
    void Start()
    {
        PlayerAttack.OnAttack += HandleAttack;
        _lastAttackTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleAttack(string currentAttack)
    {
        if (_lastAttack == null) _timeSinceLastAttack = -1;
        else _timeSinceLastAttack = Time.time - _lastAttackTime;
        OnComboTime?.Invoke(_timeSinceLastAttack);
        _lastAttack = currentAttack;
    }
}
