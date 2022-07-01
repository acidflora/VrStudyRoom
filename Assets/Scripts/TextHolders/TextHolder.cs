
public class TextHolder 
{
    public string StartText;
    public string MovingText;
    public string MovingTextDescription1;
    public string MovingTextDescription2;
    public string ActionText;
    public string ActionTextDescription;

    public string WalkingHeader { get; private set; } = "Передвижение";
    public string HelloHeader { get; private set; } = "Приветствие";
    public string ActionHeader { get; private set; } = "Взаимодействие с предметами";
    public virtual void SetText()
    {

    }
}
