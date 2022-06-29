
public class TextHolder 
{
    public string StartText;
    public string MovingText;
    public string MovingTextDescription;

    public string WalkingHeader { get; private set; } = "Передвижение";
    public string HelloHeader { get; private set; } = "Приветствие";
    public virtual void SetText()
    {

    }
}
