using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CargarDatos : MonoBehaviour
{
    public GameObject player;

    public string archivoDeGuardado;

    public SaveSystem dataGame = new SaveSystem();



    public void Awake()
    {
        archivoDeGuardado = Application.dataPath + "/datosJuego.json";

        player = GameObject.FindGameObjectWithTag("Player");

        CargarrDatos();

    }


    public void CargarrDatos()
    {
        if(File.Exists(archivoDeGuardado))
        {
            string contenido = File.ReadAllText(archivoDeGuardado);
            dataGame = JsonUtility.FromJson<SaveSystem>(contenido);

            player.transform.position = dataGame.position;
            player.GetComponent<FirstPersonController>().health = dataGame.health;
        }
        else
        {
            Debug.Log("El Archivo no existe");
        }

    }


    public void GuardarDatos()
    {
        SaveSystem newdataGame = new SaveSystem()
        {
            position = player.transform.position,
            health = player.GetComponent<FirstPersonController>().health
,        };
        
        string chainJson =  JsonUtility.ToJson(newdataGame);

        File.WriteAllText(archivoDeGuardado, chainJson);

        Debug.Log("Archivo Guardado");

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuardarDatos();
        }
    }


}
