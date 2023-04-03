using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private Transform pf_damage_popup;
    // Start is called before the first frame update
    void Start()
    {
       Transform damagePopupTranform = Instantiate(pf_damage_popup, Vector3.zero, Quaternion.identity);
       DamagePopup damagePopup = damagePopupTranform.GetComponent<DamagePopup>();
       damagePopup.Setup(3);
    }
}
