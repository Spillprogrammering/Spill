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
        //Medlemsvariabler
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
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Kan ikke koble til databasen");
                        break;

                    case 1045:
                        MessageBox.Show("Feil brukernavn/Passord når du logget inn i databasen");
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
        /// Kaller på loginFinished metoden i Login klassen hvis sjekk er OK
        /// </summary>
        public void loginCheck(Login loginRef, string username, string password) 
        {
            //Spørringen til databasen
            string query = "SELECT * FROM User WHERE Username = '" + username + "' AND Password = '" + password + "'";

            if (this.OpenConnection() == true)
            {
                //Oppretter en MySQL kommando
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Oppretter en datareader og kjører kommando
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;

                while (dataReader.Read())
                {
                    count = count + 1;
                }
                //Hvis korrekt logininfo (finner ett matchende resultat)
                if (count == 1)
                {
                    //kaller på loginFinished() metoden i Login klassen
                    loginRef.loginFinished();
                }
                else  //Gjør ingenting og be brukeren prøve å logge på en gang til....
                    MessageBox.Show("Feil brukernavn/passord kombinasjon" + Environment.NewLine + "Prøv på nytt", "Feil");
                
                //Lukker datareaderen
                dataReader.Close();

                //Lukker tilkoblingen til databasen
                this.CloseConnection();
            }
            
        }

        /// <summary>
        /// Metode som kobler til databasen og legger til bruker.
        /// Lukker så tilkoblingen til databasen etter den er ferdigkjørt.
        /// </summary>
        public void registerUser(string username, string password)
        {
            //Spørringen mot databasen som blir brukt til å sjekke om det allerede eksisterer en med samme brukernavn
            string query = "Select Username FROM User WHERE Username = '" + username + "'";
            //boolsk variabel for sjekk om det allerede eksisterer en bruker med samme brukernavn
            bool check = false;
            
            //Sjekker om man er tilkoblet databasen
            if (this.OpenConnection() == true)
            {
                //Oppretter en MySQL kommando
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Oppretter en datareader og kjører kommando
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;

                //Sjekk om det allerede eksisterer en bruker med samme brukernavn
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

                //Lukker datareaderen
                dataReader.Close();

                if (!check)
                {
                    //Spørring mot databasen som kjøres når man ikke har funnet en bruker med samme brukernavn
                    query = "INSERT INTO User (Username, Password) VALUES('" + username + "', '" + password + "')";

                    //Oppretter en MySQL kommando 
                    MySqlCommand command = new MySqlCommand(query, connection);

                    //Utfører kommandoen
                    command.ExecuteNonQuery();

                    MessageBox.Show("Bruker lagt til", "Suksess!");
                }
                else
                    MessageBox.Show("En bruker med dette navnet eksisterer allerede!" + Environment.NewLine + "Vennligst velg et annet brukernavn", "Feil");
                
            }

            //Lukker tilkoblingen til databasen
            this.CloseConnection();
        }

    }
}
