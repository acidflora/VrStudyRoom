
public class TextHolder 
{
    public string HelloDescription;
    public string MovingTextDescription;
    public string MovingTextAction1;
    public string InputTextDescription;
    public string InputTextAction;
    public string FollowTextDescription;
    public string FollowTextAction;
    public string MovingTextAction2;
    public string ActionTextDescription;
    public string ActionTextAction;
    public string GrabTextDescription;
    public string GrabTextAction;
    public string IconTextDescription;
    public string IconTextAction;
    public string MapIconTextDescription;
    public string MapIconTextAction;
    public string RadioIconTextDescription;
    public string RadioIconTextAction;
    public string MultiIconTextDescription;
    public string MultiIconTextAction;
    public string MeasureIconTextDescription;
    public string MeasureIconTextAction;
    public string PlaceIconTextDescription;
    public string PlaceIconTextAction;
    public string MenuTextDescription;
    public string MenuTextAction;

    public string WalkingHeader { get; private set; } = "Передвижение";
    public string HelloHeader { get; private set; } = "Приветствие";
    public string InputHeader { get; private set; } = "Управление";
    public string HelloDescription2 { get; private set; } = "Мы находимся в кванториуме нашего университета. Вам необходимо подготовить наш технопарк к работе. Вам потребуется выполнять несложные задачи. Внимательно следуйте поступающим инструкциям. Приступим!";
    public string ActionHeader { get; private set; } = "Взаимодействие с предметами";
    public string GrabHeader { get; private set; } = "Захват предметов";
    public string IconHeader { get; private set; } = "Взаимодействие с иконками";
    public string MultiIconHeader { get; private set; } = "Предметы с несколькими иконками";
    public string MeasureIconHeader { get; private set; } = "Проведение измерений";
    public string PlaceIconHeader { get; private set; } = "Объект";
    public string MenuHeader { get; private set; } = "Меню";
    public string EndHeader { get; private set; } = "Обучение завершено";
    public virtual void SetText()
    {

    }
}
