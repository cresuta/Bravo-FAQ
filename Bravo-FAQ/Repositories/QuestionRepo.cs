using Bravo_FAQ.Models;
using Bravo_FAQ.Utils;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Bravo_FAQ.Repositories
{
    public class QuestionRepo : BaseRepo, IQuestionRepo
    {
        public QuestionRepo(IConfiguration configuration) : base(configuration) { }

        public List<Question> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                              
                       SELECT Id, Content
                         FROM Question";

                    var reader = cmd.ExecuteReader();

                    var questions = new List<Question>();
                    while (reader.Read())
                    {
                        questions.Add(NewQuestionFromReader(reader));
                    }

                    reader.Close();

                    return questions;
                }
            }
        }

        private Question NewQuestionFromReader(SqlDataReader reader)
        {
            return new Question()
            {
                Id = DbUtils.GetInt(reader, "Id"),
                Content = DbUtils.GetString(reader, "Content")
            };
        }
    }
}
