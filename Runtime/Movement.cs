using UnityEngine;

namespace MyLibrary
{
    public class Movement : MonoBehaviour
    {
        public Vector3 PlayerMove()
        {
            // 入力を取得
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");

            // 移動ベクトルを作成
            return new Vector3(moveX, moveY, 0f);

        }
    }
}
