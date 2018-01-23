using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour {
    public GameObject playerHand;
    public GameObject equippedWeapon { get; set; }

    IWeapon i_equippedWeapon;
    EquipmentStats equipmentStats;

    private void Start()
    {
        equipmentStats = GetComponent<EquipmentStats>();

    }
    public void EquipWeapon(Item itemToEquip)
    {
        if(equippedWeapon != null)
        {
            equipmentStats.RemoveStatBonus(equippedWeapon.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0));
        }


        equippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/" + itemToEquip.ObjectSlug),
            playerHand.transform.position,playerHand.transform.rotation);

        i_equippedWeapon = equippedWeapon.GetComponent<IWeapon>();
        i_equippedWeapon.Stats = itemToEquip.itemStats;
        equippedWeapon.transform.SetParent(playerHand.transform);

        equipmentStats.AddStatBonus(itemToEquip.itemStats);

        Debug.Log(i_equippedWeapon.Stats);
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            PerformWeaponAttack();
        }
    }

    public void PerformWeaponAttack()
    {
        i_equippedWeapon.PerformAttack();
    }
}
