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
            //    case int[] values :
            //    {
            //        int value = Converts.ToInt32(obj);                 
            //        for(int idx =0; idx < bools.Length;idx++)
            //        {
            //            if ( values[idx] > value )
            //                bools[idx] = true;
            //        }
            //        break;
            //    }
            //    case Int64[] values :
            //    {
            //        Int64 value = Converts.ToInt64(obj);                 
            //        for(int idx =0; idx < bools.Length;idx++)
            //        {
            //            if ( values[idx] > value )
            //                bools[idx] = true;
            //        }
            //        break;
            //    }
            //    case float[] values :
            //    {
            //        float value = Converts.ToSingle(obj);                 
            //        for(int idx =0; idx < bools.Length;idx++)
            //        {
            //            if ( values[idx] > value )
            //                bools[idx] = true;
            //        }
            //        break;
            //    }
            //    case double[] values :
            //    {
            //        double value = Converts.ToDouble(obj);                 
            //        for(int idx =0; idx < bools.Length;idx++)
            //        {
            //            if ( values[idx] > value )
            //                bools[idx] = true;
            //        }
            //        break;
            //    }
            //    default :
            //    {
            //        throw new IncorrectTypeException();
            //    } 
            //}

            //return boolTensor.MakeGeneric<bool>();
        }

        public static NumSharp.Generic.NDArray<bool> operator >(NDArray np1, NDArray np2)
        {
            if (np1.Shape != np2.Shape)
                throw new NumSharpException("The two specified arrays must have the same shape.");

            var type1 = np1.GetData()[0].GetType();
            var type2 = np2.GetData()[0].GetType();

            var returnValue = new NumSharp.Generic.NDArray<bool>(np1.Shape);
            var returnData = returnValue.GetData();

            if (type1 == typeof(float) && type2 == typeof(float))
            {
                var data1 = np1.GetData<float>();
                var data2 = np2.GetData<float>();

                for (int i = 0; i < returnData.Count; i++)
                {
                    returnData[i] = data1[i] > data2[i];
                }
            } else if (type1 == typeof(float) && type2 == typeof(int))
            {

                var data1 = np1.GetData<float>();
                var data2 = np2.GetData<int>();

                for (int i = 0; i < returnData.Count; i++)
                {
                    returnData[i] = data1[i] > data2[i];
                }
            }
            else if (type1 == typeof(int) && type2 == typeof(int))
            {

                var data1 = np1.GetData<int>();
                var data2 = np2.GetData<int>();

                for (int i = 0; i < returnData.Count; i++)
                {
                    returnData[i] = data1[i] > data2[i];
                }
            }
            else if (type1 == typeof(int) && type2 == typeof(float))
            {

                var data1 = np1.GetData<int>();
                var data2 = np2.GetData<float>();

                for (int i = 0; i < returnData.Count; i++)
                {
                    returnData[i] = data1[i] > data2[i];
                }
            }

            return returnValue;
        }
    }
}
