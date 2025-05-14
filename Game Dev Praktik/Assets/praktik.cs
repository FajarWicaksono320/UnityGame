using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class praktik : MonoBehaviour
{
    public int playerHealth;
    public int playerArmor;
    public int playerDamage;
    // Start is called before the first frame update
    // public int health = 100;
    // public int damage = 20;
    // float speed = 0.5f;
    // bool isAlive = true;
    // string namaplayer = "Roger";
    // char grade = 'A';

    void Start()
    {
        Debug.Log("Player Status: " + GetPlayerStatus());
        Debug.Log("Effective Damage: " + CalculateEffectiveDamage());
        Debug.Log("Is Player Alive? " + IsPlayerAlive());
        // Debug.Log("Health Player : "+ health);

        // int damage = 20;
        // health = health - damage;
        // Debug.Log("Darah Sekarang : " + health);

        // bool isDeath = health <= 0;
        // Debug.Log(" Player Mati " + isDeath);

        // if(isAlive && health > 0)
        // {
        //     Debug.Log(" Player Hidup ");
        // }
        // else
        // {
        //     Debug.Log(" Player Mati ");
        // }

        // if(health > 50)
        // {
        //     Debug.Log(namaplayer + " Masih Kuat");
        // }else if(health >0)
        // {
        //     Debug.Log(" Hati-hati");
        // }
        // else
        // {
        //     Debug.Log(namaplayer + " Telah Mati");
        //     isAlive=false;
        // }
        // GetPlayerName();
        // GetPlayerStatus(20);
        // StartCoroutine(contohCorotine(2));

        // string status = GetPlayerStatus(40);
        // Debug.Log("Status Pemain " + status);

    }
    string GetPlayerStatus()
    {
        if (playerHealth > 75)
            return "Sehat";
        else if (playerHealth > 40)
            return "Luka Ringan";
        else if (playerHealth > 0)
            return "Luka Parah";
        else
            return "Mati";
    }
    int CalculateEffectiveDamage()
    {
        int effectiveDamage = playerDamage - playerArmor;
        if (effectiveDamage < 0)
            effectiveDamage = 0;

        return effectiveDamage;
    }
     bool IsPlayerAlive()
    {
        return playerHealth > 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // public void GetPlayerName()
    // {
    //     Debug.Log(namaplayer);
    // }
    // // public void GetPlayerStatus(int damage)
    // // {
    // //     health = health - damage;
    // //     Debug.Log("Darah Sisa : " + health);
    // // }
    // string GetPlayerStatus(int darah)
    // {
    //     if(darah > 50)
    //         return "Hidup";
    //     else if (darah > 0)
    //         return "Lemah";
    //     else
    //         return "Mati";
    // }
    // IEnumerator contohCorotine(int waktu)
    // {
    //     Debug.Log("Mulai Corantine");
    //     yield return new WaitForSeconds(waktu);
    //     Debug.Log("Corantine Selesai");
    // }

}
