namespace NumSharp
{
    public partial class NDArray
    {
        public static NumSharp.Generic.NDArray<bool> operator >(NDArray np, int obj)
        {
            return np > (float)obj;
        }
        public static NumSharp.Generic.NDArray<bool> operator >(NDArray np, float obj)
        {
            var data = np.GetData();
            var returnValue = new NumSharp.Generic.NDArray<bool>(np.Shape);
            var returnData = returnValue.GetData();
            var dataType = data[0].GetType();
            if (dataType == typeof(int))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    returnData[i] = (int)data[i] > obj;
                }
            }
            else if (dataType == typeof(float))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    returnData[i] = (float)data[i] > obj;
                }
            }
            else
                throw new NumSharpException("Greater than not implemented for the array data type.");

            return returnValue;
        }

        public static NumSharp.Generic.NDArray<bool> operator >(NDArray np, object obj)
        {
            return null;

            // var boolTensor = new NDArray(typeof(bool),np.shape);
            //bool[] bools = boolTensor.Storage.GetData() as bool[];

            //switch (np.Storage.GetData())
            //{
            // case int[] values :
            // {
            // int value = Converts.ToInt32(obj);
            // for(int idx =0; idx < bools.Length;idx++)
            // {
            // if ( values[idx] > value )
            // bools[idx] = true;
            // }
            // break;
            // }
            // case Int64[] values :
            // {
            // Int64 value = Converts.ToInt64(obj);
            // for(int idx =0; idx < bools.Length;idx++)
            // {
            // if ( values[idx] > value )
            // bools[idx] = true;
            // }
            // break;
            // }
            // case float[] values :
            // {
            // float value = Converts.ToSingle(obj);
            // for(int idx =0; idx < bools.Length;idx++)
            // {
            // if ( values[idx] > value )
            // bools[idx] = true;
            // }
            // break;
            // }
            // case double[] values :
            // {
            // double value = Converts.ToDouble(obj);
            // for(int idx =0; idx < bools.Length;idx++)
            // {
            // if ( values[idx] > value )
            // bools[idx] = true;
            // }
            // break;
            // }
            // default :
            // {
            // throw new IncorrectTypeException();
            // }
            //}

            //return boolTensor.MakeGeneric<bool>();
        }

        public static NumSharp.Generic.NDArray<bool> operator >(NDArray np1, NDArray np2)
        {
            if (np1.Shape != np2.Shape)
                throw new NumSharpException("The two specified arrays must have the same shape.");

            var returnValue = new NumSharp.Generic.NDArray<bool>(np1.Shape);
            var returnData = returnValue.GetData();

            switch (np1.GetTypeCode)
            {
#if _REGEN

%foreach except(supported_dtypes, "Boolean"),except(supported_dtypes_lowercase, "bool") %
case NPTypeCode.#1:
{
var data1 = np1.GetData<#2>();
switch(np2.GetTypeCode)
{
%foreach except(supported_dtypes, "Boolean"),except(supported_dtypes_lowercase, "bool") %

case NPTypeCode.#101:
{
var data2 = np2.GetData<#102>();

for (int i = 0; i < returnData.Count; i++)
{
returnData[i] = data1[i] > data2[i];
}

break;
}
%
default:
throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
}



break;
}
%

#else


                case NPTypeCode.Byte:
                    {
                        var data1 = np1.GetData<byte>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.Int16:
                    {
                        var data1 = np1.GetData<short>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.UInt16:
                    {
                        var data1 = np1.GetData<ushort>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.Int32:
                    {
                        var data1 = np1.GetData<int>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.UInt32:
                    {
                        var data1 = np1.GetData<uint>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.Int64:
                    {
                        var data1 = np1.GetData<long>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }


                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.UInt64:
                    {
                        var data1 = np1.GetData<ulong>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }


                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }


                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.Char:
                    {
                        var data1 = np1.GetData<char>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.Double:
                    {
                        var data1 = np1.GetData<double>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.Single:
                    {
                        var data1 = np1.GetData<float>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Double:
                                {
                                    var data2 = np2.GetData<double>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Single:
                                {
                                    var data2 = np2.GetData<float>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
                case NPTypeCode.Decimal:
                    {
                        var data1 = np1.GetData<decimal>();
                        switch (np2.GetTypeCode)
                        {

                            case NPTypeCode.Byte:
                                {
                                    var data2 = np2.GetData<byte>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int16:
                                {
                                    var data2 = np2.GetData<short>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt16:
                                {
                                    var data2 = np2.GetData<ushort>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int32:
                                {
                                    var data2 = np2.GetData<int>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt32:
                                {
                                    var data2 = np2.GetData<uint>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Int64:
                                {
                                    var data2 = np2.GetData<long>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.UInt64:
                                {
                                    var data2 = np2.GetData<ulong>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Char:
                                {
                                    var data2 = np2.GetData<char>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }

                            case NPTypeCode.Decimal:
                                {
                                    var data2 = np2.GetData<decimal>();

                                    for (int i = 0; i < returnData.Count; i++)
                                    {
                                        returnData[i] = data1[i] > data2[i];
                                    }

                                    break;
                                }
                            default:
                                throw new IncorrectTypeException("The right hand side tensor did not have a compatible type.");
                        }



                        break;
                    }
#endif

            }

            return returnValue;
        }
    }
}
