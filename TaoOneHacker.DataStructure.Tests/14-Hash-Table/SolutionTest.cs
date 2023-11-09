using TaoOneHacker.DataStructure.Core._14_HashTables._01_Hash_Table_Basics;
using Xunit;

namespace TaoOneHacker.DataStructure.Tests._14_Hash_Table;

public class SolutionTest
{
    [Fact]
    public void TestFirstUniqChat()
    {
        var solution = new Solution();
        var s = "leetcode";

        var result = solution.FirstUniqChar(s);
        Assert.Equal(0, result);

        s = "loveleetcode";
        result = solution.FirstUniqChar(s);
        Assert.Equal(2, result);

        s = "aabb";
        result = solution.FirstUniqChar(s);
        Assert.Equal(-1, result);
    }
}