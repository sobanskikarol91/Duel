using UnityEngine;
using System.Collections;
using System;

[CreateAssetMenu(fileName = "Wonder", menuName = "Wonder")]
public class Wonder : Buyable
{
    public Skill[] _actions;
    public Sprite sprite;
    bool moveAgain;
    int exp;
    int addMoney;
}

//public class ApianWay : Wonder
//{
//    //bool MoveAgain;
//    //int exp = 3;
//    //int addMoney;
//    int removeEnemyMoney;
//}

//public class CircusMaximus : Wonder
//{
//    bool destroyEnemyManufactureCard;
//    int increaseMilitary = 1;
//    int exp = 3;
//}

//public class Colossus : Wonder
//{
//    int increaseMilitary = 1;
//    int exp = 3;
//}

//public class GreateLibrary : Wonder
//{
//    void ChooseFreeToken() { }
//}

//public class GreateLightHouse : Wonder
//{
//    //wood/brick/rock
//    int exp = 4;
//}

//public class HangingGardens : Wonder
//{
//    int addMoney = 6;
//    bool MoveAgain;
//    //wood/brick/rock
//    int exp = 3;
//}

//public class Mausoleum : Wonder
//{
//    void ChoosDiscardedCard() { };
//    int exp = 2;
//}

//public class Messe : Wonder
//{
//    void ChoosCardFromTop() { };
//    int exp = 2;
//}


//public class Piraeus : Wonder
//{
//    // glass or papyrus
//    bool MoveAgain;
//}

//public class Pyramids : Wonder
//{
//    int exp = 9;
//}

//public class Sphinx : Wonder
//{
//    bool MoveAgain;
//    int exp = 9;
//}

//public class StatueOfZeus : Wonder
//{
//    bool destroyRawMaterialCard;
//    int increaseMilitary = 1;
//    int exp = 3;
//}

//public class TempleOfArtemis : Wonder
//{
//    bool MoveAgain;
//    int addMoney = 12;
//}