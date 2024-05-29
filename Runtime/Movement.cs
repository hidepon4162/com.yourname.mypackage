using UnityEngine;

namespace MYLibrary
{
    public class Movement : MonoBehaviour
    {
        public float moveSpeed = 5f;

        // Update is called once per frame
        void Update()
        {
            // 入力を取得
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");

            // 移動ベクトルを作成
            Vector3 move = new Vector3(moveX, moveY, 0f);

            // プレイヤーを移動させる
            transform.position += move * moveSpeed * Time.deltaTime;
        }
    }
}