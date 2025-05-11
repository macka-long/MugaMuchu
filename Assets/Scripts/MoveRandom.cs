using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    public Transform shoulder;
    public float moveRadius = 1.0f; // 大きく動かす

    public void MoveRandomly()
    {
        if (shoulder == null) return;

        // ランダム方向の単位ベクトル
        Vector3 direction = Random.onUnitSphere;

        // 半径をかけて距離を持たせる
        Vector3 offset = direction * moveRadius;

        // 肩の位置を基準に、IKターゲットを移動
        transform.position = shoulder.position + offset;
    }
}
