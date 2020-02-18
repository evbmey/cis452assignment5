using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private RPSFactory factory;

    public void Awake()
    {
        factory = new RPSFactory();
    }

    public void Spawn(string rpsName)
    {
        GameObject newObject = Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
        newObject.AddComponent(factory.CreateRPS(rpsName));
    }
}
