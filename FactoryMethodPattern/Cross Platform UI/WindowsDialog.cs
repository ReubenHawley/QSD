using FactoryMethodPattern.Base;

namespace FactoryMethodPattern.Cross_Platform_UI;

public class WindowsDialog : Creator
{
    public override IProduct SomeOperation()
    {
        throw new NotImplementedException();
    }
}