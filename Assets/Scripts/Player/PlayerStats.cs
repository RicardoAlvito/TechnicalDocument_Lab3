using System;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player Stats")]

public class PlayerStats : ScriptableObject
{
        [Header("Config")]
        [SerializeField] private int lvlplayer = 1;

        [Header("Health")]
        [SerializeField] private float hpplayer = 10f; 
        [SerializeField] private int hpmaxplayer = 10;
        public float HpPlayer
        {
            get => hpplayer;
            set => hpplayer = value;
        }

        public int HpMaxPlayer => hpmaxplayer;
        public int LvlPlayer => lvlplayer;
}
