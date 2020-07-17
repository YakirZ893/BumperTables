using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenarteEnemies : MonoBehaviour
{

    public GameObject EnemeyT;
    [SerializeField] private int xPos;
    [SerializeField] private int zPos;
    public int enemyCount;

    [SerializeField] private float Sec = 10f;

    void Start()
    {
        StartCoroutine(EnemyDrop());
        StartCoroutine(EnemyDrop2());
        StartCoroutine(EnemyDrop3());
    }


    void Update()
    {

    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(-74, -34);
            zPos = Random.Range(-1, -12);
            Instantiate(EnemeyT, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Sec);
            enemyCount += 1;
        }
    }

    IEnumerator EnemyDrop2()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(10, -14);
            zPos = Random.Range(-20, -31);
            Instantiate(EnemeyT, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Sec);
            enemyCount += 1;
        }


    }

    IEnumerator EnemyDrop3()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(99, 108);
            zPos = Random.Range(0, -12);
            Instantiate(EnemeyT, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Sec);
            enemyCount += 1;
        }
    }
}
