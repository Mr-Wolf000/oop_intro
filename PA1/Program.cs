// The excersise can be thought of in two ways, we need to find the largest negative number.
// You can think of this as finding the number closest to 0 and is negative, or the number that is the furthers away from 0 that is still negative.
// I understand the excersise under the assumtion of finding the negative number furthest away from 0.

int[] nums = [-20,10,-40,8,2,3,5,-90,-2,-73]; // For nums we assume that there is at least one value and that the first value is negative.
int minNum = nums[0]; // Takes the first value that is assumed to be negative.

// Looks up all numbers, and if a value is found, that is less than the minNum then assign minNum that value.
foreach (int number in nums) {
    if (number < minNum) {
        minNum = number;
    }
}
Console.WriteLine("The largest negative number found in the array is {0}",minNum);