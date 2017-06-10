    public string LicenseKeyFormatting(string S, int K) 
        {
            StringBuilder sb = new StringBuilder();
            int charLen = 0;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] != '-')
                {
                    if (charLen > 0 && charLen % K == 0)
                    {
                        sb.Append('-');
                    }
                    sb.Append(Char.ToUpper(S[i]));
                    charLen++;
                }
            }
            
            char[] chars = sb.ToString().ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
}
