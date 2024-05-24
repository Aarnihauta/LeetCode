﻿namespace TrueLeetCode.Leetcode.Pointers;

//https://leetcode.com/problems/merge-sorted-array/
public class L88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m + n - 1;
        m--;
        n--;

        while (n >= 0)
        {
            if (m >= 0 && nums1[m] > nums2[n])
            {
                nums1[i] = nums1[m];
                m--;
            }
            else
            {
                nums1[i] = nums2[n];
                n--;
            }
            i--;

        }
    }
}
