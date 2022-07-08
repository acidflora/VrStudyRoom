
public class TextHolder 
{
    public string StartTextDescription;
    public string MovingTextDescription;
    public string MovingTextAction1;
    public string MovingTextAction2;
    public string ActionTextDescription;
    public string ActionTextAction;
    public string GrabTextDescription;
    public string GrabTextAction;
    public string IconTextDescription;
    public string IconTextAction;
    public string MultiIconTextDescription;
    public string MultiIconTextAction;

    public string WalkingHeader { get; private set; } = "Передвижение";
    public string HelloHeader { get; private set; } = "Приветствие";
    public string ActionHeader { get; private set; } = "Взаимодействие с предметами";
    public string GrabHeader { get; private set; } = "Граб предметов";
    public string IconHeader { get; private set; } = "Взаимодействие с иконками";
    public string MultiIconHeader { get; private set; } = "Предметы с несколькими иконками";
    public virtual void SetText()
    {

    }
}
