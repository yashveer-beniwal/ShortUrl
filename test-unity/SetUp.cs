using System;
using testunity.Data;
namespace testunity
{
    public class SetUp:ISetUp
    {
        private IStorage _storage;
        public SetUp(IStorage storage)
        {
            _storage = storage;

        }

        public void createInitialCurrentTable()
        {
            _storage.AddValueToHash(Constants.CurrentIdTable, Constants.CurrentId, "50000");
        }
    }
}
