using System;
using System.Collections.Generic;

namespace GT5SaveGameLibrary
{
    public class PddbObject
    {
        public string Symbol { get; set; }
        public byte ByteValue { get; set; }
        public Type ValueType { get; set; }
        public object Value { get; set; }
        public IEnumerable<PddbObject> ChildObjects { get; set; }

        public PddbObject(byte byteValue, Type valuetype, object value, IEnumerable<PddbObject> childObjects)
        {
            ByteValue = byteValue;
            ValueType = valuetype;
            Value = value;
            ChildObjects = childObjects;
        }
    }
}
