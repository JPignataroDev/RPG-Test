using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public PlayerWeaponController playerWeaponController;
    public Item _Sword;

    void Start()
    {
        playerWeaponController = GetComponent<PlayerWeaponController>();
        
        List<BaseStat> swordStats = new List<BaseStat>();
        swordStats.Add(new BaseStat(4, "Slash Attack Bonus", "Slash modifiers"));
        _Sword = new Item(swordStats, "Sword");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            playerWeaponController.EquipWeapon(_Sword);
        }

        
    }
}
