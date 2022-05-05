
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

type AiSimpleParallel struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
    FinishMode int32
    MainTask interface{}
    BackgroundNode interface{}
}

const TypeId_AiSimpleParallel = -1952582529

func (*AiSimpleParallel) GetTypeId() int32 {
    return -1952582529
}

func (_v *AiSimpleParallel)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiSimpleParallel)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("_v.NodeName error"); return } }
    {_v.Decorators = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Decorators error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeAiDecorator(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Decorators = append(_v.Decorators, _e_) } }
    {_v.Services = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Services error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeAiService(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Services = append(_v.Services, _e_) } }
    { if _v.FinishMode, err = _buf.ReadInt(); err != nil { err = errors.New("_v.FinishMode error"); return } }
    { if _v.MainTask, err = DeserializeAiTask(_buf); err != nil { err = errors.New("_v.MainTask error"); return } }
    { if _v.BackgroundNode, err = DeserializeAiFlowNode(_buf); err != nil { err = errors.New("_v.BackgroundNode error"); return } }
    return
}

func DeserializeAiSimpleParallel(_buf *serialization.ByteBuf) (*AiSimpleParallel, error) {
    v := &AiSimpleParallel{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}