using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentStats : MonoBehaviour {
    public List<BaseStat> equipStats = new List<BaseStat>();

    private void Start()
    {
        //Attack Bonuses.
        equipStats.Add(new BaseStat(0, "Stab Attack Bonus", "Stab modifiers"));
        equipStats.Add(new BaseStat(0, "Slash Attack Bonus", "Slash modifiers"));
        equipStats.Add(new BaseStat(0, "Crush Attack Bonus", "Crush modifiers"));
        equipStats.Add(new BaseStat(0, "Magic Attack Bonus", "Magic modifiers"));
        equipStats.Add(new BaseStat(0, "Range Attack Bonus", "Range modifiers"));

        //Defence
        equipStats.Add(new BaseStat(0, "Stab Defence Bonus", "Stab modifiers"));
        equipStats.Add(new BaseStat(0, "Slash Defence Bonus", "Slash modifiers"));
        equipStats.Add(new BaseStat(0, "Crush Defence Bonus", "Crush modifiers"));
        equipStats.Add(new BaseStat(0, "Magic Defence Bonus", "Magic modifiers"));
        equipStats.Add(new BaseStat(0, "Range Defence Bonus", "Range modifiers"));

        //Other Bonuses
        equipStats.Add(new BaseStat(0, "Melee Strength", "The strength bonus, coupled with a player's strength level"));
        equipStats.Add(new BaseStat(0, "Ranged Strength", "The 'strength' bonus of ammo"));
        equipStats.Add(new BaseStat(0, "Magic Strength", "This increases the damage dealt of a spell."));
        equipStats.Add(new BaseStat(0, "Prayer", "Lowers the drain rate of prayers"));

        //Target Specific
        equipStats.Add(new BaseStat(0, "Undead", "Undead damage modifiers"));
        equipStats.Add(new BaseStat(0, "Slayer", "Slayer damage modifiers"));
    }


    public void AddStatBonus(List<BaseStat> statBonuses)
    {
        foreach(BaseStat statBonus in statBonuses)
        {
            equipStats.Find(x => x.StatName == statBonus.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }
    public void RemoveStatBonus(List<BaseStat> statBonuses)
    {
        foreach (BaseStat statBonus in statBonuses)
        {
            equipStats.Find(x => x.StatName == statBonus.StatName).RemoveStatBonus(new StatBonus(statBonus.BaseValue));
        }
    }

}
