using UnityEngine;

public class Inimigo : MonoBehaviour
{
    [Header("Status")]
    [SerializeField] private int Dano = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ddd");
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(Dano);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
