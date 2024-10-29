// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");


Dictionary<string, int> not = new Dictionary<string, int>();
not.Add("aa", 20);

foreach (var item in not)
{
    Console.WriteLine("key = {0} , value = {1}", item.Key, item.Value);
}

Console.WriteLine(not.Count);


Console.WriteLine("---------------------------------------------------");

MyDictionaryy<string, int> bb = new MyDictionaryy<string, int>();
bb.Add("bb", 2);

// ?
//foreach (var item in bb)
//{
//    Console.WriteLine("key = {0} , value = {1}", item.Key, item.Value);
//}
//Console.WriteLine(bb.Count);

public class MyDictionaryy<TKey, TValue>
{
    TKey[] _key;
    TValue[] _value;

    TKey[] _tempKeyArray;
    TValue[] _tempValueArray;
    public MyDictionaryy()
    {
        _key = new TKey[0];
        _value = new TValue[0];
    }
    public void Add(TKey key, TValue value)
    {
        _tempKeyArray = _key;
        _tempValueArray = _value;
        _key = new TKey[_key.Length + 1];
        _value = new TValue[_key.Length + 1];

        for (int i = 0; i < _tempKeyArray.Length; i++)
        {
            _key[i] = _tempKeyArray[i];
        }
        _key[_key.Length-1] = key;
        for (int i = 0; i < _tempValueArray.Length; i++)
        {
            _value[i] = _tempValueArray[i];
        }
        _value[_value.Length-1] = value;
    }

    public int Count { get { return _key.Length; } }
}
