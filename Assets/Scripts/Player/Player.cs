using UnityEngine;
using UnityEngine.EventSystems;



public class Player : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;

    
    public PlayerStats Stats => playerStats;
}