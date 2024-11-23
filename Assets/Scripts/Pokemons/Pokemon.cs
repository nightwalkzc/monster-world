using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

// Pokemon作为最基础的c#类
public class Pokemon
{

    // 对口袋妖怪基类引用
    PokemonBase _base;

    int level;
    public int Hp {get; set; }

    // 这里为什么用public修饰
    //{get; set;}方法意义？
    public List<Move> moves {get; set;}  

    // 普通基类必须通过构造函数分配变量
    public Pokemon(PokemonBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
        Hp = pBase.MaxHp;

        // 根据级别生成技能模式,后续增加学习技能逻辑
        moves = new List<Move>();
        foreach(var move in _base.LearnableMoves)
        {

            if (moves.Count >= 4)
                break;

            if (move.Level <= level)
                moves.Add(new Move(move.MoveBase));
        }
    }

    public int MaxHp {
        get {return Mathf.FloorToInt((_base.MaxHp * level) / 100f) + 10; }
    }

    public int Attack {
        get {return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5; }
    }

    public int Defense {
        get {return Mathf.FloorToInt((_base.Defence * level) / 100f) + 5; }
    }

    public int SpAttack {
        get {return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5; }
    }

    public int SpDefense {
        get {return Mathf.FloorToInt((_base.SpDefense * level) / 100f) + 5; }
    }

    public int Speed {
        get {return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }

}
