using FactoryMethodPattern.Base;

namespace FactoryMethodPattern.Cross_Platform_UI;

public class AndroidDialog : Dialog
{
    public void DoStuff()
    {
        throw new NotImplementedException();
    }

    public override void Render()
    {
        throw new NotImplementedException();
    }

    public override IProduct CreateButton()
    {
        throw new NotImplementedException();
    }
}