
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "luban_examples/go_bin/bright/serialization"
)

import "errors"

type BonusWeightBonusInfo struct {
    Bonus interface{}
    Weight int32
}

const TypeId_BonusWeightBonusInfo = -907244058

func (*BonusWeightBonusInfo) GetTypeId() int32 {
    return -907244058
}

func (_v *BonusWeightBonusInfo)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BonusWeightBonusInfo)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Bonus, err = DeserializeBonusBonus(_buf); err != nil { err = errors.New("_v.Bonus error"); return } }
    { if _v.Weight, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Weight error"); return } }
    return
}

func DeserializeBonusWeightBonusInfo(_buf *serialization.ByteBuf) (*BonusWeightBonusInfo, error) {
    v := &BonusWeightBonusInfo{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}