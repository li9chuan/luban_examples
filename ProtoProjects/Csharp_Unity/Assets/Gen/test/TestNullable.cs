//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;

namespace proto.test
{

    public  sealed class TestNullable :  Bright.Serialization.BeanBase 
    {
        public TestNullable()
        {
        }

        public TestNullable(Bright.Common.NotNullInitialization _) 
        {
            F2 = "";
            F3 = new test.Simple();
        }

        public static void SerializeTestNullable(ByteBuf _buf, TestNullable x)
        {
            x.Serialize(_buf);
        }

        public static TestNullable DeserializeTestNullable(ByteBuf _buf)
        {
            var x = new test.TestNullable();
            x.Deserialize(_buf);
            return x;
        }

         public int? F1;

         public string F2;

         public test.Simple F3;

         public test.Dyn F4;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            { if(F1 is int __value__){ _buf.WriteBool(true); _buf.WriteInt(__value__); } else { _buf.WriteBool(false); } }
            { if(F2 is string __value__){ _buf.WriteBool(true); _buf.WriteString(__value__); } else { _buf.WriteBool(false); } }
            { if(F3 is test.Simple __value__){ _buf.WriteBool(true); test.Simple.SerializeSimple(_buf, __value__); } else { _buf.WriteBool(false); } }
            { if(F4 is test.Dyn __value__){ _buf.WriteBool(true); test.Dyn.SerializeDyn(_buf, __value__); } else { _buf.WriteBool(false); } }
        }

        public override void Deserialize(ByteBuf _buf)
        {
            if(_buf.ReadBool()){ F1 = _buf.ReadInt(); } else { F1 = null; }
            if(_buf.ReadBool()){ F2 = _buf.ReadString(); } else { F2 = null; }
            if(_buf.ReadBool()){ F3 = test.Simple.DeserializeSimple(_buf); } else { F3 = null; }
            if(_buf.ReadBool()){ F4 = test.Dyn.DeserializeDyn(_buf); } else { F4 = null; }
        }

        public override string ToString()
        {
            return "test.TestNullable{ "
            + "F1:" + F1 + ","
            + "F2:" + F2 + ","
            + "F3:" + F3 + ","
            + "F4:" + F4 + ","
            + "}";
        }
    }

}