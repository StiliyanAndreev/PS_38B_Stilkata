✅ What You Have Implemented:
User Authentication System:

Users are stored in a collection (UserData).
Login system verifies username & password using ValidateCredentials().
If credentials are valid, user details are displayed.
LINQ-based User Operations:

GetUser() → Finds user by name & password.
SetActive() → Updates the expiration date.
AssignUserRole() → Changes the user’s role.
Logging System:

Logs each successful login.
Logs failed login attempts with errors.
Logs are stored in a file (log.txt).
✅ Commands to Test Your Code
1. Run the Program
sh
Copy
Edit
dotnet run
Expected Output:
It will prompt for username and password.
If valid, it prints user details.
If invalid, it logs the failed attempt and throws an error.
2. Check the Log File
sh
Copy
Edit
cat log.txt
This will display:
Successful logins (User XYZ logged in at [time]).
Failed attempts (Invalid credentials for user XYZ at [time]).
3. Test User Login Scenarios
Try different inputs:

Correct Credentials:

Enter a valid username & password.
Should print "LOGIN SUCCESSFUL" and user details.
Wrong Credentials:

Enter incorrect username/password.
Should print "User not found" and log the error.