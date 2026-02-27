using System;

public class UserProfile
{
    String fio;
    int cash;
    String status;

    String email1;
    String password;

    public UserProfile(String fio, int cash, String status, String email, String passwd)
	{
        fio = fio;
        cash = cash;
        status = status;
        email1 = email;
        password = passwd;
	}

    public String getEmail() { return this.email1; }
    public String getPassword() { return this.password; }
}
