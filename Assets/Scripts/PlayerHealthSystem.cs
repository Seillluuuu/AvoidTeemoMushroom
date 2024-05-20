using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSystem : MonoBehaviour
{
    public int maxHp = 100;
    private int currentHp;

    public Slider hpSlider;
    public Text hpText;

    public bool isDead = false;

    private void Start()
    {
        currentHp = maxHp;
    }

    private void Update()
    {
        hpText.text = currentHp.ToString() + " / " + maxHp.ToString();
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;

        if (currentHp < 0) currentHp = 0;

        UpdateHpUI();

        if (currentHp == 0)
        {
            Die();
        }
    }

    void UpdateHpUI()
    {
        if (hpSlider != null) hpSlider.value = currentHp;
    }

    public void Die()
    {
        isDead = true;
    }
}
