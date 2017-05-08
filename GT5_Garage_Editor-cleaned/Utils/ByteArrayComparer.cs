using System;
using System.Runtime.InteropServices;

namespace GT5_Garage_Editor.Utils
{
    [StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
    internal static class ByteArrayComparer
    {
        internal static bool smethod_0(byte[] array1, byte[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();
            if (array1 == array2)
                return true;
            if (array1.Length != array2.Length)
                return false;
            for (var index = 0; index < array1.Length; ++index)
            {
                if (array1[index] != array2[index])
                    return false;
            }
            return true;
        }
    }
}
