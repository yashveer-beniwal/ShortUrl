using System;
namespace testunity.Services
{
    public interface IConversion
    {
        string Encode(ulong value);
        ulong Decode(string value);
    }
}
