using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {
    public List<BaseStat> stats = new List<BaseStat>();

    private void Start()
    {
        stats.Add(new BaseStat(1, "Attack", "Attack Skill"));
        stats.Add(new BaseStat(1, "Strength", "Strength Skill"));
        stats.Add(new BaseStat(1, "Defence", "Defence Skill"));
        stats.Add(new BaseStat(1, "Magic", "Magic Skill"));
        stats.Add(new BaseStat(1, "Range", "Range Skill"));

        stats.Add(new BaseStat(10, "Health Points", "Health Points"));
    }
}
