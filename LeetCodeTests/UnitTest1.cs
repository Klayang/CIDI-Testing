using LeetCodeConsole;

namespace LeetCodeTests;

public class UnitTest1
{
    [Fact]
    public void TestTwoSum()
    {
        // 定义leetcode问题的输入
        int[] nums = [2, 7, 11, 15];
        int target = 9;

        // 执行two sum问题求解
        int[] result = LeetcodeSolutions.TwoSum(nums, target);

        // 执行测试
        int[] expected = [0, 2];
        Assert.Equal(expected, result);
    }
}
