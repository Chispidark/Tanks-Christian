using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4;
    public int xPos;
    public int zPos;
    public int botiquinCount;
    public int fuerzaCount;
    public int velocidadCount;
    public int invencibleCount;

    private void Start()
    {
        StartCoroutine(BotiquinDrop());
        StartCoroutine(FuerzaDrop());
        StartCoroutine(VelocidadDrop());
        StartCoroutine(InvencibleDrop());
    }

    IEnumerator BotiquinDrop()
    {
        while (botiquinCount < 5)
        {
            xPos = UnityEngine.Random.Range(-43, 43);
            zPos = UnityEngine.Random.Range(-43, 43);

            Instantiate(prefab1, new Vector3(xPos, 1, zPos), Quaternion.identity);
            

            yield return new WaitForSeconds(10f);
            botiquinCount++;
        }
    }

    IEnumerator FuerzaDrop()
    {
        while (fuerzaCount < 2)
        {
            xPos = UnityEngine.Random.Range(-43, 43);
            zPos = UnityEngine.Random.Range(-43, 43);

            Instantiate(prefab2, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(10f);
            fuerzaCount++;
        }
    }

    IEnumerator VelocidadDrop()
    {
        while (velocidadCount < 2)
        {
            xPos = UnityEngine.Random.Range(-43, 43);
            zPos = UnityEngine.Random.Range(-43, 43);

            Instantiate(prefab3, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(10f);
            velocidadCount++;
        }
    }

    IEnumerator InvencibleDrop()
    {
        while (invencibleCount < 2)
        {
            xPos = UnityEngine.Random.Range(-43, 43);
            zPos = UnityEngine.Random.Range(-43, 43);

            Instantiate(prefab4, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(10f);
            invencibleCount++;
        }
    }


}
