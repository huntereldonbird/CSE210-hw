namespace Learning04;

public class MathAssignmnet: assignment
{
    private String _textbookSection;
    private String _problems;

    public String get_textbookSection(String text)
    {
        if (text != null)
        {
            _textbookSection = text;
        }
        return _textbookSection;
    }

    public String get_problems(String problems)
    {
        if (problems != null)
        {
            _problems = problems;
        }
        return _problems;
    }

    public MathAssignmnet(String text, String problems, String name, String topic)
    {
        get_textbookSection(text);
        get_problems(problems);
        get_studentName(name);
        get_topic(topic);
    }
    
    public String GetHomeworkList()
    {
        return null;
    }
}