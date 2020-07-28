using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharStats : MonoBehaviour
{
    public Text name_;
    public Text level;
    public Text money;
    public Text health;
    public Text shield;
    public Text attackPower;
    public Text spellPower;
    private readonly string charSelected = "charSelected";
    
    private void Start()
    {
        


        
        
    }
    private void Update()
    {
        int getChar;
        getChar = PlayerPrefs.GetInt(charSelected);
        switch (getChar)
        {
            case 1:
                GameObject Octopus = GameObject.Find("octo");
                PlayerScript octoData = Octopus.GetComponent<PlayerScript>();
                name_.text = octoData.playerName;
                level.text = "Level : " + octoData.playerLevel.ToString();
                money.text = "Money : " + octoData.playerMoney.ToString();
                health.text = "Health : " + octoData.playerHealth.ToString();
                shield.text = "Shield : " + octoData.playerShield.ToString();
                attackPower.text = "Attack : " + octoData.playerAttackDamage.ToString();
                spellPower.text = "Spell : " + octoData.playerSpellDamage.ToString();
                


                //string octoName = octoData.playerName;
                //int octoMoney = octoData.playerMoney;
                //int octoLevel = octoData.playerLevel;
                //int octoHealth = octoData.playerHealth;
                //int octoShield = octoData.playerShield;
                //int octoAttack = octoData.playerAttackDamage;
                //int octoSpell = octoData.playerSpellDamage;
                //Debug.Log(octoSpell);



                break;
            case 2:
                GameObject Turtle = GameObject.Find("tort");
                PlayerScript tortData = Turtle.GetComponent<PlayerScript>();
                string tortName = tortData.playerName;
                int tortMoney = tortData.playerMoney;
                int tortLevel = tortData.playerLevel;
                int tortHealth = tortData.playerHealth;
                int tortShield = tortData.playerShield;
                int tortAttack = tortData.playerAttackDamage;
                int tortSpell = tortData.playerSpellDamage;

                name_.text = tortName;
                level.text = "Level : " + tortLevel.ToString();
                money.text = "Money : " + tortMoney.ToString();
                health.text = "Health : " + tortHealth.ToString();
                shield.text = "Shield : " + tortShield.ToString();
                attackPower.text = "Attack : " + tortAttack.ToString();
                spellPower.text = "Spell : " + tortSpell.ToString();
                break;
            case 3:
                GameObject Crab = GameObject.Find("crab");
                PlayerScript crabData = Crab.GetComponent<PlayerScript>();
                string crabName = crabData.playerName;
                int crabMoney = crabData.playerMoney;
                int crabLevel = crabData.playerLevel;
                int crabHealth = crabData.playerHealth;
                int crabShield = crabData.playerShield;
                int crabAttack = crabData.playerAttackDamage;
                int crabSpell = crabData.playerSpellDamage;

                name_.text = crabName;
                level.text = "Level : " + crabLevel.ToString();
                money.text = "Money : " + crabMoney.ToString();
                health.text = "Health : " + crabHealth.ToString();
                shield.text = "Shield : " + crabShield.ToString();
                attackPower.text = "Attack : " + crabAttack.ToString();
                spellPower.text = "Spell : " + crabSpell.ToString();
                break;
            default:

                break;
        }
    }
}
