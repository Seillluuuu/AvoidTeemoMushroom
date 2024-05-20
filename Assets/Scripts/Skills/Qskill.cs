using UnityEngine;

public class Qskill : AbstractSkill
{
    PlayerMovement playerMovement;

    public float speedMultiplier = 2f;

    public override void Activate(GameObject player)
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.speed *= speedMultiplier;
        }
    }

    public override void Deactivate(GameObject player)
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        if (playerMovement != null)
        {
            playerMovement.speed /= speedMultiplier;
        }
    }
}