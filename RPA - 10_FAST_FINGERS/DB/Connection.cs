using Npgsql;


namespace RPA___10_FAST_FINGERS.DB
{
    internal class Connection
    {

        internal static NpgsqlConnection LocalHost()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=iclopes;Password=password;Database=10_Fast_Fingers;");
            return conn;
        }


        internal static void Insert_Data(int wpm, int keystrokes, int acurracy, int correct_words, int wrong_words)
        {
            NpgsqlConnection conn = LocalHost();

            conn.Open();
            string sql = $"Insert into Return (Date, Wpm, Keystrokes, Accuracy, Correct_Words, Wrong_Words) " +
                $"Values(Now(), {wpm}, {keystrokes}, {acurracy}, {correct_words}, {wrong_words})";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();


            conn.Close();
        }

    }
}
