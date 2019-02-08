using System;
using System.Data;
using System.Data.SqlClient;

namespace Movie_Databse
{
    internal class Database
    {
        private SqlConnection SCNT = new SqlConnection();
        private SqlCommand SCMD = new SqlCommand();
        private SqlDataAdapter DA = new SqlDataAdapter();
        public string ConnectionString = null;
        // (20) Setup the Database stuff

        public Database()
        {
            string ConfigPath = @".\blockbusted_config.bin";
            ConnectionString = System.IO.File.ReadAllText(ConfigPath);
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            // (21) Get the connection string
        }

        public DataTable Fill()
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            // (22) these lines of code are repeated in every method because some nasty bugs where happening with the SCMD.Connection value
            // They only take about .1 ms to resolve but its something i would like to look at later on to increase efficiency
            // But at the end of it all it was an easy choice between safety and security vs efficiency
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("select * from Movies ", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
            // (23) bring me more movies please
        }

        public LoginInfo CheckLogin(string Username)
        {
            // (24) Most of the methods in this class are extremely self explanatory (especially so with SQL Server Management) so i am going to stick to explaining the stand out methods instead of going through them all
            // (25) For example this method returns all the login data (including a hashed password as a string) when the Username is given
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Get_Login_Data";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@Username", Username);
                SCNT.Open();
                SqlDataReader Reader = CMD.ExecuteReader();
                while (Reader.Read())
                {
                    LoginInfo.User = Reader["Username"].ToString();
                    LoginInfo.Password = Reader["Password"].ToString();
                    LoginInfo.Security = Reader["Security"].ToString();
                }
                Reader.Close();
                SCNT.Close();
                return LoginInfo;
            }
        }

        public void ChangePassword(string Username, string NewPassword)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "ChangePassword";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@Username", Username);
                CMD.Parameters.AddWithValue("@NewPassword", NewPassword);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void AddCustomer(string FirstName, string LastName, string Address, string Phone)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Add_Customer";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@FirstName", FirstName);
                CMD.Parameters.AddWithValue("@LastName", LastName);
                CMD.Parameters.AddWithValue("@Address", Address);
                CMD.Parameters.AddWithValue("@Phone", Phone);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public DataTable FillDGVCustomer()
        {
            // (26) I think this is the oldest code that is written in the program, it still has the template comments!
            // There was a few more comments but i deleted them out, left this set here because it is actually quite informative

            //create a datatable as we only have one table, the Owner
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("select * from Customer", SCNT))
            {
                //connect in to the DB and get the SQLConnection.Open();
                //open a connection to the DB
                DA.Fill(DT);
                //fill the datatable from the SQL
                SCNT.Close(); //close the connection
            }
            return DT; //pass the datatable data to the DataGridView
        }

        public DataTable FillMoviesOut()
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("select * from MoviesOut", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
        }

        public DataTable FillMoviesWithCopies()
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("select * from MoviesWithCopies", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
        }

        public void UpdateCustomer(string CustID, string FirstName, string LastName, string Address, string Phone)
        {
            // (27) The first large style Method in our class, it gets much worse from here on.
            // But still retaining the same simpleness as the previous methods so not much to say
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Update_Customer";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@CustID", CustID);
                CMD.Parameters.AddWithValue("@FirstName", FirstName);
                CMD.Parameters.AddWithValue("@LastName", LastName);
                CMD.Parameters.AddWithValue("@Address", Address);
                CMD.Parameters.AddWithValue("@Phone", Phone);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void ReturnMovie(string RMID, DateTime DateRented, string Title)
        {   // (28) That DateTime is created using the .ToString().Remove(.Length-12) function on a much larger date time further on in our Menu class, (at least im pretty sure it is?)
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "ReturnMovie";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@RMID", RMID);
                CMD.Parameters.AddWithValue("@DateRented", DateRented);
                CMD.Parameters.AddWithValue("@Title", Title);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void RentMovie(string MovieID, string CustID)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "RentMovie";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@MovieID", MovieID);
                CMD.Parameters.AddWithValue("@CustID", CustID);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void ChangeMoviesCosts(string Year, string Cost)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "UpdateMoviesCosts";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@Year", Year);
                CMD.Parameters.AddWithValue("@Cost", Cost);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public DataTable FillMoviesByRenting()
        { // (29) These two methods relate to the reports section of the Form Operations part of the assessment criteria 
            // "List who borrows the most videos and list what are the most popular videos."
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("SELECT Title,Year,Rental_Cost,Copies,Times_Rented_Out From Movies ORDER BY Times_Rented_Out DESC", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
        }

        public DataTable FillCustomersByRenting()
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("SELECT * FROM Customer ORDER BY Times_Rented_Movies DESC", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
        }

        public void DeleteCustomer(string CustID)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "DeleteCustomer";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@CustID", CustID);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void AddEmployee(string Username)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Add_Employee";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@Username", Username);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public DataTable FillLogins()
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("SELECT UserID,Username FROM Logins WHERE Security = 'E'", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
        }

        public void Elevate(string UserID, string Username)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Elevate";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@UserID", UserID);
                CMD.Parameters.AddWithValue("@Username", Username);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void TerminateEmployee(string UserID, string Username)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Terminate_Employee";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@UserID", UserID);
                CMD.Parameters.AddWithValue("@Username", Username);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void DeleteMovie(string MovieID)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "DeleteMovie";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@MovieID", MovieID);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void Add_Movie(string Title, string Year, string Rating, string Released, string Runtime, string Genre, string Director, string Writer, string Actors, string Plot, string Language, string Country, string Awards, string Metascore, string Copies)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Add_Movie";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@Title", Title);
                CMD.Parameters.AddWithValue("@Year", Year);
                CMD.Parameters.AddWithValue("@Rating", Rating);
                CMD.Parameters.AddWithValue("@Released", Released);
                CMD.Parameters.AddWithValue("@Runtime", Runtime);
                CMD.Parameters.AddWithValue("@Genre", Genre);
                CMD.Parameters.AddWithValue("@Director", Director);
                CMD.Parameters.AddWithValue("@Writer", Writer);
                CMD.Parameters.AddWithValue("@Actors", Actors);
                CMD.Parameters.AddWithValue("@Plot", Plot);
                CMD.Parameters.AddWithValue("@Language", Language);
                CMD.Parameters.AddWithValue("@Country", Country);
                CMD.Parameters.AddWithValue("@Awards", Awards);
                CMD.Parameters.AddWithValue("@Metascore", Metascore);
                CMD.Parameters.AddWithValue("@Copies", Copies);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public void Update_Movie(string Title, string Year, string Rating, string Released, string Runtime, string Genre, string Director, string Writer, string Actors, string Plot, string Language, string Country, string Awards, string Metascore, string Copies, string MovieID)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Update_Movie";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@Title", Title);
                CMD.Parameters.AddWithValue("@Year", Year);
                CMD.Parameters.AddWithValue("@Rating", Rating);
                CMD.Parameters.AddWithValue("@Released", Released);
                CMD.Parameters.AddWithValue("@Runtime", Runtime);
                CMD.Parameters.AddWithValue("@Genre", Genre);
                CMD.Parameters.AddWithValue("@Director", Director);
                CMD.Parameters.AddWithValue("@Writer", Writer);
                CMD.Parameters.AddWithValue("@Actors", Actors);
                CMD.Parameters.AddWithValue("@Plot", Plot);
                CMD.Parameters.AddWithValue("@Language", Language);
                CMD.Parameters.AddWithValue("@Country", Country);
                CMD.Parameters.AddWithValue("@Awards", Awards);
                CMD.Parameters.AddWithValue("@Metascore", Metascore);
                CMD.Parameters.AddWithValue("@Copies", Copies);
                CMD.Parameters.AddWithValue("@MovieID", MovieID);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }

        public DataTable FillAdminLogins()
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("SELECT UserID,Username FROM Logins WHERE Security = 'A'", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            return DT;
        }

        public void Demote_Admin(string UserID, string Username)
        {
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            LoginInfo LoginInfo = new LoginInfo();
            using (SqlCommand CMD = SCNT.CreateCommand())
            {
                CMD.CommandText = "Demote_Admin";
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.AddWithValue("@UserID", UserID);
                CMD.Parameters.AddWithValue("@Username", Username);
                SCNT.Open();
                CMD.ExecuteNonQuery();
                SCNT.Close();
            }
        }
    }
}

// (30) Can't think of much more to add here so i will probably leave it at that, onto LonginInfo.cs