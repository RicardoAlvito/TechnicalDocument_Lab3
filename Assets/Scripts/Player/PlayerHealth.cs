using UnityEngine;
using Unity;
public class PlayerHealth : MonoBehaviour, IDamageable
{
    [SerializeField]private PlayerStats PlayerStats;
    private PlayerAnimations playerAnimations;
     public void TakeDamage(float amount){
        PlayerStats.HpPlayer -= amount;


        if (PlayerStats.HpPlayer <= 0) {
            PlayerDead();
            return;
        }
    }
    void Awake() {
        if (PlayerStats != null)
        {
            PlayerStats.HpPlayer = PlayerStats.HpMaxPlayer;
        }

        playerAnimations = GetComponent<PlayerAnimations>();
    }
    void PlayerDead()
    {
        Debug.Log("Jogador morreu");


        if (playerAnimations != null) {
            playerAnimations.SetDeadAnimation();
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1f);
        }

    }
}
