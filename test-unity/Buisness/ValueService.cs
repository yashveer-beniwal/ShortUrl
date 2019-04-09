using System;
using System.Collections.Generic;

namespace testunity.Buisness
{
    public interface IValueService
    {
        List<string> GetValues();
    }

    public class ValueService : IValueService
    {
        public ValueService()
        {
        }

        public List<string> GetValues()
        {
            return new List<string>() { "asdas", "asdasd" };
        }
    }
}
