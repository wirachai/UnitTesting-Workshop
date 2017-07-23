namespace SampleMock.Interfaces
{
    public interface IValidator
    {
        bool IsValid { get; set; }

        void Validate();
    }
}