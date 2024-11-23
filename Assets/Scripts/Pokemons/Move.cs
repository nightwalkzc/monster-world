using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
      //问题：为什么不使用简单的方法在move基类中创建：在检视器中需要显示变量不能使用<短方法>？
    public MoveBase Base {get; set;}

    // 思考：需要动态变化的数据，作为技能的动态实体在战斗状态中变化，是move；静态的是MoveBase
    public int PP {get; set;}

    public Move (MoveBase pBase)
    {
        Base = pBase;
        PP = pBase.PP;
    }
}
