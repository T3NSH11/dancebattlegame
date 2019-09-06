using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for converting a battle result into xp to be awarded to the player.
/// 
/// TODO:
///     Respond to battle outcome with xp calculation based on;
///         player win 
///         how strong the win was
///         stats/levels of the dancers involved
///     Award the calculated XP to the player stats
///     Raise the player level up event if needed
/// </summary>
public class XPHandler : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnPlayerLevelUp += GameEvents_OnPlayerLevelUp;
        GameEvents.OnBattleConclude += GameEvents_OnBattleConclude;
    }

    private void GameEvents_OnBattleConclude(BattleResultEventData data)
    {
        GainXP(data);
    }


    private void GameEvents_OnPlayerLevelUp(int level)
    {
       

    }

    private void OnDisable()
    {
    }

    public void GainXP(BattleResultEventData data)
    {
        data.player.xp = data.player.xp + (int)((data.outcome * 100) / data.player.level);
    }
}
