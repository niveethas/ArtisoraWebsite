namespace ArtisoraWebsite
{
    public class CurrentUser
    {
      
            public static int? _role;
            public static int? _userid;
            public static string? _useremail;

            public int? Role { get { return _role; } set { _role = value; } }
            public int? UserId { get { return _userid; } set { _userid = value; } }
            public string UserEmail { get { return _useremail; } set { _useremail = value; } }
    }

}
