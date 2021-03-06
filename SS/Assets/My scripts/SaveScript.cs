/*
 @SaveScript.cs
 This store all the static values which will be used throughtout the game.
 This will store all the value of the current state as the variables are static irrespective of the class the value of below variable will global 
 For example PlayerHealth Goes down from 100 to 80 and if other classes are called 
 than the value of health will remain 80 or might decrease depends on the operation a call performs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveScript : MonoBehaviour
{
    public static int PlayerHealth = 100; // Thus variable will be used as Player Health
    public static bool HealthChanged = false; // This variable is refered if health of the player is updated
    public static float BatteryPower = 1.0f; // This is the initial value of Battery Power
    public static bool FlashLightOn = false; // Initally the Flashlight will be off.
    public static bool NightVisionLightOn = false; // Initally the night vision will be off.    
    public static bool knife = false;
    public static bool MagicSword = false; // This variable is to check if knife is been picked up or not
    public static bool axe = false; // This variable is to check if axe is been picked up or not
    public static bool gun = false; // This variable is to check if gun is been picked up or not
    public static int Apples = 0; // This variable is to check how many apples are picked.
    public static bool crossbow = false;
    public static bool HaveKnife = false;
    public static bool HaveMagicSword = false;
    public static bool HaveAxe = false;
    public static bool HaveGun = false;
    public static bool HaveCrossBow = false;
    public static int reward = 0;
    public static int Bullets = 30;
    public static int Arrows = 4;
    public static bool NewGame = false;
    public static int activeG = 4;

    private void Start(){
        if (NewGame == true){
            PlayerHealth = 100; // This variable will be used as Player Health
            HealthChanged = false; // This variable is refered if health of the player is updated
            BatteryPower = 1.0f; // This is the initial value of Battery Power
            FlashLightOn = false; // Initally the Flashlight will be off.
            NightVisionLightOn = false; // Initally the night vision will be off.    
            knife = false;
            MagicSword = false; // This variable is to check if knife is been picked up or not
            axe = false; // This variable is to check if axe is been picked up or not
            gun = false; // This variable is to check if gun is been picked up or not
            Apples = 0; // This variable is to check how many apples are picked.
            crossbow = false;
            HaveKnife = false;
            HaveMagicSword = false;
            HaveAxe = false;
            HaveGun = false;
            HaveCrossBow = false;
            reward = 0;
            Bullets = 30;
            Arrows = 4;
            activeG = 4;
        }
    }

    /*public static bool Knife = false;
    public static bool Gun = false;
    public static bool Axe = false;
*/}
