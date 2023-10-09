namespace FacadePattern;

public class Facade
{
    protected SubSystem _subsystem1;
    protected SubSystem2 _subsystem2;

    public Facade(SubSystem subsystem1,SubSystem2 subsystem2)
    {
        _subsystem1 = subsystem1;
        _subsystem2 = subsystem2;
    }

    public string Operation()
    {
        string result = "Facade initializes subsystems:\n";
        result += _subsystem1.operation1();
        result += _subsystem2.operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += _subsystem1.operationZ();
        result += _subsystem2.operationZ();
        return result;
    }

    public string Operation2()
    {
        string result = "Facade initializes subsystems:\n";
        result += _subsystem1.operation1();
        result += _subsystem2.operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += _subsystem1.operationZ();
        result += _subsystem2.operationZ();
        return result;
    }
}