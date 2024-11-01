namespace Learning04;

public class WritingAssignmnet: assignment
{
    private String _title;

    public String get_title(String title)
    {
        if (title != null)
        {
            _title = title;
        }
        
        return _title;
    }


    public String GetWritingInformation()
    {
        return null;
    }
}