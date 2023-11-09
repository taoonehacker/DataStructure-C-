using TaoOneHacker.DataStructure.Core._14_HashTables._05_Hash_Table_Implementation;
using Xunit;

namespace TaoOneHacker.DataStructure.Tests._14_Hash_Table;

public class HashTableTest
{
    private static HashTable<string, string> _hashTable;

    public HashTableTest()
    {
        _hashTable = new HashTable<string, string>();
    }

    [Fact]
    public void AddTest()
    {
        for (int i = 0; i < 10; i++)
        {
            _hashTable.Add(i.ToString(), i.ToString());
        }

        Assert.Equal(10, _hashTable.Size());
    }

    [Fact]
    public void RemoveTest()
    {
        _hashTable.Add("key1", "value1");
        var value = _hashTable.Remove("key1");

        Assert.Equal("value1", value);
        Assert.Equal(0, _hashTable.Size());

        value = _hashTable.Remove("key2");
        Assert.Equal(default, value);
    }

    [Fact]
    public void GetTest()
    {
        _hashTable.Add("key1", "value1");
        var value = _hashTable.Get("key1");
        Assert.Equal("value1", value);
    }
    
    [Fact]
    public void SetTest()
    {
        _hashTable.Add("key1", "value1");
        _hashTable.Set("key1", "value2");
        var value = _hashTable.Get("key1");
        Assert.Equal("value2", value);
    }

    [Fact]
    public void SizeTest()
    {
        for (int i = 0; i < 10; i++)
        {
            _hashTable.Add(i.ToString(), i.ToString());
        }

        Assert.Equal(10, _hashTable.Size());
    }
    
    [Fact]
    public void ContainsTest()
    {
        _hashTable.Add("key1", "value1");

        Assert.True(_hashTable.Contains("key1"));
        Assert.False(_hashTable.Contains("key2"));
    }
}