using SampleMock.Interfaces;

namespace SampleMock.Validators
{
    public class Validator_Stub : IValidator
    {
        public bool IsValid { get; set; }

        public void Validate()
        {
        }
    }
}