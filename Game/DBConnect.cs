using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Konstruktør
        public DBConnect()
        {
            Initialize();
        }

        //Initialiserer verdier og setter opp en kobling til databasen
        private void Initialize()
        {
            server = "kark.hin.no";
            database = "BRP_DB1";
            uid = "bjornrp";
            password = "bjornrp123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Metode som åpner tilkoblingen til databasen
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Metode som lukker tilkoblingen til databasen
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Metode for å sjekke innlogging
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void loginCheck(Login loginRef, string username, string password) 
        {
            string query = "SELECT * FROM User WHERE Username = '" + username + "' AND Password = '" + password + "'";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;

                while (dataReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    //MessageBox.Show("Korrekt brukernavn og passord");
                    //FormView level1 = new FormView();
                    //level1.Show();
                }
                else 
                    //MessageBox.Show("Feil brukernavn/passord kombinasjon");
                
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            loginRef.loginFinished();
        }

        /// <summary>
        /// Metode for å koble til databasen og legge til bruker.
        /// Lukker så tilkoblingen til databasen.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void registerUser(string username, string password)
        {
            string query = "Select Username FROM User WHERE Username = '" + username + "'";
            bool check = false;
            
            //open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;

                while (dataReader.Read())
                {
                    count = count + 1;
                }

                if (count >= 1)
                {
                    check = true;
                }
                else
                    check = false;

                //close Data Reader
                dataReader.Close();


                if (!check)
                {
                    query = "INSERT INTO User (Username, Password) VALUES('" + username + "', '" + password + "')";

                    //create command and assign the query and connection from the constructor
                    MySqlCommand command = new MySqlCommand(query, connection);

                    //Execute command
                    command.ExecuteNonQuery();

                    MessageBox.Show("Bruker lagt til", "Suksess!");
                }
                else
                    MessageBox.Show("En bruker med dette navnet eksisterer allerede!" + Environment.NewLine + "Vennligst velg et annet brukernavn");
                
            }

            //close connection
            this.CloseConnection();
        }

    }
}
