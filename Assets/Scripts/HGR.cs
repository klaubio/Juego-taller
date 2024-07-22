using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HGR : MonoBehaviour
{

    [SerializeField] private StarterAssets.FirstPersonController player;

    public bool isOnCooldown = false;
    public bool isOnCooldownSpeed = false;
    public bool isOnCooldownHealth = false;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!isOnCooldown)
            {
                StartCoroutine(HGRDamage());
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!isOnCooldownSpeed)
            {
                StartCoroutine(HGRVelocity());
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!isOnCooldownHealth)
            {
                StartCoroutine(HGRHealth());
            }
        }

    }
    public IEnumerator HGRDamage()
    {
        isOnCooldown = true;

        float valorAleatorio = Random.value * 100f;

        if (valorAleatorio < 25f)
        {
            player.ModifyDamage(25);
        }
        else if (valorAleatorio < 45f)
        {
            player.ModifyDamage(20);
        }
        else if (valorAleatorio < 60f)
        {
            player.ModifyDamage(15);
        }
        else if (valorAleatorio < 85f)
        {
            player.ModifyDamage(10);
        }
        else if (valorAleatorio < 95f)
        {
            player.ModifyDamage(15);
        }
        else if (valorAleatorio < 100f)
        {
            player.ModifyDamage(1);
        }
        else 
        {
            player.ModifyDamage(0);
            Debug.Log("0 de daño");
        }

        yield return new WaitForSeconds(24f);

        isOnCooldown = false;
    }

    public IEnumerator HGRVelocity()
    {
        isOnCooldownSpeed = true;

        float valorAleatorio = Random.value * 100f;

        if (valorAleatorio < 25f)
        {
            player.ModifySpeed(10);
        }
        else if (valorAleatorio < 45f)
        {
            player.ModifySpeed(10);
        }
        else if (valorAleatorio < 60f)
        {
            player.ModifySpeed(10);
        }
        else if (valorAleatorio < 85f)
        {
            player.ModifySpeed(10);
        }
        else if (valorAleatorio < 95f)
        {
            player.ModifySpeed(10);
        }
        else if (valorAleatorio < 100f)
        {
            player.ModifySpeed(10);
        }
        else
        {
            player.ModifySpeed(0);
        }

        yield return new WaitForSeconds(25f);

        isOnCooldownSpeed = false;
    }

    public IEnumerator HGRHealth()
    {
        isOnCooldownHealth = true;

        float valorAleatorio = Random.value * 100f;

        if (valorAleatorio < 25f)
        {
            player.ModifyHealth(50);
            Debug.Log("recuperas 50 de vida");

        }
        else if (valorAleatorio < 45f)
        {
            player.ModifyHealth(30);
            Debug.Log("recuperas 30 de vida");
        }
        else if (valorAleatorio < 60f)
        {
            player.ModifyHealth(25);
            Debug.Log("recuperas 25 de vida");
        }
        else if (valorAleatorio < 85f)
        {
            player.ModifyHealth(20);
            Debug.Log("recuperas 20 de vida");
        }
        else if (valorAleatorio < 95f)
        {
            player.ModifyHealth(15);
            Debug.Log("recuperas 15 de vida");
        }
        else if (valorAleatorio < 100f)
        {
            player.ModifyHealth(5);
            Debug.Log("recuperas 5 de vida");
        }
        else
        {
           
            Debug.Log("Moriste");
        }

        yield return new WaitForSeconds(18f);

        isOnCooldownHealth = false;
    }





}
