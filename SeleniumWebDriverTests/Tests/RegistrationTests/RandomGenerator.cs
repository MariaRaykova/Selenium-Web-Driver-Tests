using System;

namespace SeleniumWebDriverTests
{
    public class RandomGenerator
    {
        public static string GenerateMail()
        {
            return $"{Guid.NewGuid()}@gmail.com";
        }
      
    }
}
