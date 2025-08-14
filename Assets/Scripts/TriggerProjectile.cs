using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject projectile in projectiles)
        {
            if (other.gameObject.tag == "Player")
            {
                projectile.SetActive(true);
            }
        }
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
