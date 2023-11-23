using UnityEngine;
using System.Collections;
public class CreateEnemy : MonoBehaviour
{
    // 間隔
    [SerializeField] private float span = 2f;

    // 敵
    [SerializeField] private GameObject enemy;

    void Start()
    {
        StartCoroutine("Logging");
    }

    IEnumerator Logging()
    {
        while (true)
        {
            yield return new WaitForSeconds(span);
            int rnd = Random.Range(-10, 10);
            while (Mathf.Abs(rnd) < 5)
            {
                rnd = Random.Range(-10, 10);
            }
            Instantiate(enemy, new Vector3((float)rnd, 0.7f, (float)rnd), Quaternion.identity);
        }
    }
}