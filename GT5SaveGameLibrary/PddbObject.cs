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

        public PddbObject(string symbol, byte byteValue, Type valuetype, object value, List<PddbObject> childObjects)
        {
            Symbol = symbol;
            ByteValue = byteValue;
            ValueType = valuetype;
            Value = value;
            ChildObjects = childObjects;
        }
    }
}
