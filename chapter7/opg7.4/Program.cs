int[] nums = [1,2,3,4,7,5];
int maxnum = nums[0];
foreach (int num in nums) {
    if (maxnum<num) {
        maxnum = num;
    }
}
Console.WriteLine(maxnum);