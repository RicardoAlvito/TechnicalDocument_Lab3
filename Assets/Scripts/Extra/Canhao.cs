using UnityEngine;

public class Canhao : MonoBehaviour
{

    private Transform player = null;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player = collision.GetComponent<Transform>();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            player = null;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector2 direcao = player.position=transform.position;
            float angulo = Mathf.Atan2(direcao.x, direcao.y)* Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler( new Vector3(0, 0, angulo));
        }
    }
}
