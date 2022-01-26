// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int maxside(int[] nums)
{
    if(nums.Length <=1)
        return 0;
    if (nums[0] + nums[1] <= 3)
        return 0;
    if (nums[1] < nums[0])
    {
        int temp = nums[0];
        nums[0] = nums[1];
        nums[1] = temp;
    }
    if (nums[1] / 4 >= nums[0])
        return nums[1] / 4;
    else if ( (nums[0] / 2 <= nums[1] / 2) || (nums[1] / 3 <= nums[0]))
        return Math.Max( nums[0] / 2, nums[1] / 3) ;

    return 0;
}

int[] nums = new int[] { 4,16};
int res = maxside(nums);
Console.WriteLine(res);