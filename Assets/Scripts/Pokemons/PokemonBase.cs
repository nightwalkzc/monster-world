using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CreateAssetMenu:创建脚本对象实例的方法，底层不了解
[CreateAssetMenu(fileName = "PokemonBase", menuName = "Pokemon/Create New Pokemon")]
public class PokemonBase : ScriptableObject {

    [SerializeField] string name;  // SerializeField :编写脚本对象使用序列化的字段而不是公开变量

    [TextArea]  // TextArea:文本区，设置本文空间用于描述，底层不了解
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;   // 在战斗中的前后样式
    [SerializeField] Sprite backSprite;
    
    [SerializeField] PokemonTpye pokemonTpye1;
    [SerializeField] PokemonTpye pokemonTpye2;

    //基本属性
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;




    public string Name { //使用函数获取变量而不是直接展示  & properties特性 
        get {return name;}
    }

    public string Description { 
        get {return description;}
    }

    public int Attack { 
        get {return attack;}
    }

    public int Defence { 
        get {return defense;}
    }

    public int SpAttack { 
        get {return spAttack;}
    }

    public int SpDefense { 
        get {return spDefense;}
    }

    public int MaxHp { 
        get {return maxHp;}
    }

    public int Speed {
        get {return speed;}
    }
    
}

public enum PokemonTpye
{
    None, // 不清楚的设计含义
    Normal,
    Fire,
    Water,
    Grass,
    Electric,
    Ice,
    Fighting,
    Posion,
    Ground,
    Rock,
    Flying,
    Psychic,
    Bug,
    Ghost,
    Drgon

}

