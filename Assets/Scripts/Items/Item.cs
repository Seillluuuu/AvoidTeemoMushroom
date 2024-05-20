using System;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    private void Start()
    {
        // 아이템 효과를 이벤트에 추가
        ItemManager.Instance.ItemEvent += ItemEffect;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // 땅에 접촉 시 파괴
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        // 플레이어와 접촉 시 아이템 효과를 발동시키고 파괴
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Invincible"))
        {
            ItemManager.Instance.UseItem(collision.gameObject);
            Destroy(gameObject);
        }
    }

    // 아이템 효과를 자식 클래스에서 구현
    public abstract void ItemEffect(GameObject player);
}
