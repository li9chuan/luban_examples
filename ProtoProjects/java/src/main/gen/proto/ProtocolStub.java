//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package proto;

import java.util.*;
import bright.net.*;

public final class ProtocolStub {
    static final Map<Integer, IProtocolCreator> _factories = new HashMap<>();

    static {
        _factories.put(proto.test.TestProto1.__ID__, proto.test.TestProto1::new);
        _factories.put(proto.test.Foo.__ID__, proto.test.Foo::new);

        _factories.put(proto.test.TestRpc.__ID__, proto.test.TestRpc::new);
        _factories.put(proto.test.TestRpc2.__ID__, proto.test.TestRpc2::new);
    }

    public static Map<Integer, IProtocolCreator> getFactories() {
        return _factories;
    }
}