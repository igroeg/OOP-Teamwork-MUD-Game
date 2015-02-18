﻿namespace ForsakenLands.Characters
{
    using ForsakenLands.Items;
    using System.Collections.Generic;

    public class Warrior : Character
    {
        public Warrior(
            int id,
            int attackPoints,
            int defencePoints,
            int healthPoints,
            int accuracy,
            int evasion,
            int range,
            List<Item> itemInventory)
            : base(id, attackPoints, defencePoints, healthPoints, accuracy, evasion, range, itemInventory)
        {

        }
    }
}