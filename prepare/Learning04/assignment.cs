namespace Learning04;

public class assignment
{
    private String _studentName;
    private String _topic;

    
    // For prof Gibbons, this is the way I personaly like to do get/set, I think it is way more clever,
    // Although i know it is technically worse lol.
    
    // the idea is if you pass a null, you only get the name back, and if you do pass something other than null, 
    // it updates it. Just wanted to clerify.
    public String get_studentName(String studentName)
    {
        if (studentName != null)
        {
            _studentName = studentName;
        }
        return _studentName;
    }

    public String get_topic(String topic)
    {
        if (_studentName != null)
        {
            _topic = topic;
        }
        return _topic;
    }

    public assignment()
    {
        
    }

    public assignment(String studentName, String topic)
    {
        get_studentName(studentName);
        get_topic(topic);
    }



public String GetSummery()
    {

        return null;
    }
}