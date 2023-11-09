using System.Collections.Generic;

namespace TaoOneHacker.DataStructure.Core._14_HashTables._07_More_About_Resizing_In_Hash_Table;

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
    private static readonly int[] Capacity =
    {
        53, 97, 193, 389, 769, 1543, 3079, 6165, 12289, 24593, 49157, 98317, 196613, 786433, 1572869, 3145739, 6291469,
        12582917, 25165843, 50331653, 100663319, 201326611, 402653189, 805306457,
        1610612741
    };

    private const int UpperTol = 10;
    private const int LowerTol = 2;
    private Dictionary<K, V>[] _hashTable;
    private int _capacityIndex = 0;
    private int M;
    private int _size;

    public HashTable()
    {
        this.M = Capacity[_capacityIndex];
        _hashTable = new Dictionary<K, V>[M];
        for (int i = 0; i < M; i++)
        {
            _hashTable[i] = new Dictionary<K, V>();
        }
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
            if (_size > UpperTol * Capacity[_capacityIndex] && _capacityIndex < Capacity.Length - 1)
            {
                Resize(Capacity[++_capacityIndex]);
            }
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
            if (_size < LowerTol * Capacity[_capacityIndex] && _capacityIndex > 0)
            {
                Resize(Capacity[--_capacityIndex]);
            }
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

    private void Resize(int newCapacity)
    {
        var newHashTable = new Dictionary<K, V>[newCapacity];
        for (int i = 0; i < newCapacity; i++)
        {
            newHashTable[i] = new Dictionary<K, V>();
        }

        var oldM = M;
        this.M = newCapacity;
        for (int i = 0; i < oldM; i++)
        {
            var map = _hashTable[i];
            foreach (var key in map.Keys)
            {
                newHashTable[Hash(key)].Add(key, map[key]);
            }
        }

        this._hashTable = newHashTable;
    }
}