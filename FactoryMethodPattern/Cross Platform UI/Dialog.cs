namespace FactoryMethodPattern.Cross_Platform_UI;

public abstract class Dialog
{
    public abstract void Render();
    public abstract IProduct CreateButton();

}