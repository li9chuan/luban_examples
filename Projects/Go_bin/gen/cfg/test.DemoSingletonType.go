
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

type TestDemoSingletonType struct {
    Id int32
    Name string
    Date interface{}
}

const TypeId_TestDemoSingletonType = 539196998

func (*TestDemoSingletonType) GetTypeId() int32 {
    return 539196998
}

func (_v *TestDemoSingletonType)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *TestDemoSingletonType)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _, err = _buf.ReadString(); err != nil { return }; if _v.Name, err = _buf.ReadString(); err != nil { err = errors.New("_v.Name error"); return } }
    { if _v.Date, err = DeserializeTestDemoDynamic(_buf); err != nil { err = errors.New("_v.Date error"); return } }
    return
}

func DeserializeTestDemoSingletonType(_buf *serialization.ByteBuf) (*TestDemoSingletonType, error) {
    v := &TestDemoSingletonType{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
