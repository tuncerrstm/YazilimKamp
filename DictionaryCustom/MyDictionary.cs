using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryCustom
{
    class MyDictionary<TKey, TValue>
    {
        public TKey[] keys;
        public TValue[] values;
        public TKey[] tempKeys;
        public TValue[] tempValues;
        TValue value;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public TValue Get(TKey index)
        {
            foreach (TKey key in keys)
            {
                if (key.ToString() == index.ToString())
                {
                    value = GetValueFromKey(key);
                    break;
                }
            }
            return value;
        }

        public TValue GetValueFromKey(TKey key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].ToString().Equals(key.ToString()))
                {
                    value = values[i];
                    return value;
                }
            }
            return value;
        }


    }
}