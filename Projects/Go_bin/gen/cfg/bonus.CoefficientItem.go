
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

type BonusCoefficientItem struct {
    BonusId int32
    BonusList *BonusItems
}

const TypeId_BonusCoefficientItem = -229470727

func (*BonusCoefficientItem) GetTypeId() int32 {
    return -229470727
}

func (_v *BonusCoefficientItem)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *BonusCoefficientItem)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.BonusId, err = _buf.ReadInt(); err != nil { err = errors.New("_v.BonusId error"); return } }
    { if _v.BonusList, err = DeserializeBonusItems(_buf); err != nil { err = errors.New("_v.BonusList error"); return } }
    return
}

func DeserializeBonusCoefficientItem(_buf *serialization.ByteBuf) (*BonusCoefficientItem, error) {
    v := &BonusCoefficientItem{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}