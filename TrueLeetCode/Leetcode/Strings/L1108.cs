namespace TrueLeetCode.Leetcode.Strings;

//https://leetcode.com/problems/defanging-an-ip-address/
public class L1108
{
    public string DefangIPaddr(string address)
    {
        return address.Replace(".", "[.]");
    }
}
