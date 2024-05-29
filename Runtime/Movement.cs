using UnityEngine;

namespace MyLibrary
{
    public static class Movement
    {
        // プレイヤーの移動入力を取得し、移動ベクトルを返す
        public static Vector3 PlayerMove()
        {
            // 入力を取得
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");

            // 移動ベクトルを作成
            return new Vector3(moveX, moveY, 0f);
        }
    }
}
