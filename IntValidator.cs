using System;

namespace ConsoleApp1.Validators
{
    class IntValidator
    {
        public static bool Validate(int value)
        {
            return value > 0;
        }
    }
}
