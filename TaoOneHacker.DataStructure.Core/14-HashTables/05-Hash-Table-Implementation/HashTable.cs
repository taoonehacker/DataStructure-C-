using System.Collections.Generic;

namespace TaoOneHacker.DataStructure.Core._14_HashTables._05_Hash_Table_Implementation;

/// <summary>
/// 哈希表又称为散列表，是一种以[key-value]存储的数据结构，可以理解为是一种高级的数组。
/// TableSize表示为数组的大小，把key映射到数组下标的行为，叫做散列函数。
/// 常见的散列函数有
/// 1.Separate Chaining 分离链法
/// 2.Open Addressing 开放地址法
///     2，1 线性探测法
///     2.2 平方探测法
///     2.3 双散列法
/// 3.Rehashing 再哈希法
/// 4.Coalesced hashing 综合了Separate Chaining与Open Addressing的优点
/// </summary>
/// <typeparam name="K"></typeparam>
/// <typeparam name="V"></typeparam>
public class HashTable<K, V>
{
    private Dictionary<K, V>[] _hashTable;
    private int M;
    private int _size;

    public HashTable(int m)
    {
        this.M = m;
        _hashTable = new Dictionary<K, V>[M];
        for (int i = 0; i < M; i++)
        {
            _hashTable[i] = new Dictionary<K, V>();
        }
    }

    public HashTable() : this(97)
    {
    }

    public void Add(K key, V value)
    {
        var map = _hashTable[Hash(key)];
        if (map.ContainsKey(key))
        {
            map[key] = value;
        }
        else
        {
            map[key] = value;
            _size++;
        }
    }

    public V Remove(K key)
    {
        var map = _hashTable[Hash(key)];
        V result = default;
        if (map.ContainsKey(key))
        {
            result = map[key];
            map.Remove(key);
            _size--;
        }

        return result;
    }

    public V Get(K key)
    {
        return _hashTable[Hash(key)][key];
    }

    public void Set(K key, V value)
    {
        var map = _hashTable[Hash(key)];
        if (map.ContainsKey(key))
        {
            map[key] = value;
        }
    }

    public bool Contains(K key)
    {
        return _hashTable[Hash(key)].ContainsKey(key);
    }

    public int Size()
    {
        return _size;
    }


    private int Hash(K key)
    {
        return (key.GetHashCode() & 0x7fffffff) % M;
    }
}