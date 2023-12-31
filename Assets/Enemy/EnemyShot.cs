using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject shellPrefab;
    public int count;

    void Update()
    {
        count += 1;

        // （ポイント）
        // 1０フレームごとに砲弾を発射する
        if (count % 10 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();

            // 弾速は自由に設定
            shellRb.AddForce(transform.forward * 500);

            // 10秒後に砲弾を破壊する
            Destroy(shell, 10.0f);
        }
    }
}