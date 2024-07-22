using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToenemy : MonoBehaviour
{

    [SerializeField] private StarterAssets.FirstPersonController player;
 



    private void Start()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {

        Enemy enemyHealth = other.GetComponent<Enemy>();
        if (other.CompareTag("Ghost"))
        {

          
            enemyHealth.TakeDamage(player.damage);
        }
    }



}
