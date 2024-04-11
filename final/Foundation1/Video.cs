public class Video
{
    public string _title;
    public string _author;
    public string _videoLength;
    public List<Comment> _comments = new List<Comment>();
    
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public string GetComments()
    {
        string commentString = "\nComments:\n";
        int i = 0;
        foreach (Comment comment in _comments)
        {
            commentString = commentString + $"{++i}. {comment._commentText}\n";
        }
        return commentString;
    }
}