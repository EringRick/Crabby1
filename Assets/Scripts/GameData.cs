using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public class Player
    {
        public string playerName;
        public string playerDescription;
        public string globalId;
        public int playerMoney;
        public int playerLevel;
        public int maxEnergy;
        public int currentEnergy;
        public int playerHealth;
        public int playerShield;
        public int playerAttackDamage;
        public int playerSpellDamage;
        public int playerRage;
        public int attackQty;
        public int upgradeLeft;
        public bool canUpgrade;
        public bool canAttack;
    }
    public class Level
    {
        public int currentLevel;
        public int maxLevel;
        public int currentExp;
        public int recdExp;
        public int expForLevelUp;
        public bool levelUp;
        public int newPlayerLevel;
        public int newPlayerHealth;
        public int newPlayerShield;
        public int newPlayerDamage;
        public int newMaxEnergy;
    }
    public class Unit
    {
        public string unitName;
        public string unitDescription;
        public string globalId;
        public int unitHealth;
        public int unitShield;
        public int unitAttackDamage;
        public int unitSpellDamage;
        public int unitRage;
        public int attackQty;
        public int upgradeLeft;
        public bool canUpgrade;
        public bool isPlayable;
        public bool isBoss;
        public bool canAttack;
    }
    public static class unitList
    {
        public static List<Unit> Units;
        public static void Initiate()
        {
            Units = new List<Unit>
            {
                new Unit
                {
                    
                }
            };
        }
    }
    
    public class Item
    {
        public string itemName;
        public string itemDescription;
        public Sprite itemSprite;
        public int width;
        public int height;
        public string globalId;
        public int itemsCount;
        public bool canUse;
        public bool isPart;
        public bool isResource;
        public bool canStack;
        public int stackMaxSize;
        public Color setFrameColor;
    }
    
    public static void playerUpgrade(int up)
    {
        
        //switch (up)
        //{
        //    case 1://увеличение атаки
        //        playerAttackDamage = playerAttackDamage + (playerAttackDamage * 0.2);
        //        upgradeLeft--;//кол-во апгрейдов на юнит ограничено
        //        canUpgrade = false;//сразу после апгрейда того же юнита апгрейдить нельзя
        //        break;
        //    case 2://увеличение маг атаки
        //        playerSpellDamage = playerSpellDamage + (playerSpellDamage * 0.2);
        //        upgradeLeft--;
        //        canUpgrade = false;
        //        break;
        //    case 3://увеличение щилда
        //        playerShield = playerShield + (playerShield * 0.2);
        //        upgradeLeft--;
        //        canUpgrade = false;
        //        break;
        //    case 4://увеличение хп
        //        playerHealth = playerHealth + (playerHealth * 0.2);
        //        upgradeLeft--;
        //        canUpgrade = false;
        //        break;
        //    case 5://лвл ап
        //        playerLevel++;
        //        currentEnergy = maxEnergy;
        //        maxEnergy = maxEnergy + (maxEnergy * 0.1);
        //        playerAttackDamage = playerAttackDamage + (playerAttackDamage * 0.05);
        //        playerSpellDamage = playerSpellDamage + (playerSpellDamage * 0.05);
        //        playerShield = playerShield + (playerShield * 0.05);
        //        playerHealth = playerHealth + (playerHealth * 0.05);
        //}
    }
    public static class itemList
    {
        public static List<Item> Items;
        public static void Initiate()
        {
            Items = new List<Item>
            {
                new Item
                {
                    itemName = "Empty bottle",
                    itemDescription = "Bottle, just empty plastic bottle",
                    width = 1,
                    height = 1,
                    globalId = "id00123",
                    itemsCount = 1,
                    canUse = false,
                    isPart = false,
                    isResource = true,
                    canStack = true,
                    stackMaxSize = 20,
                    setFrameColor = Color.grey,
                }
            };
        }
    }
}
