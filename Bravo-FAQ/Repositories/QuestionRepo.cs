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

        public void Add(Question question)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO Question (
                            Content)
                        OUTPUT INSERTED.ID
                        VALUES (
                             @Content)";

                    DbUtils.AddParameter(cmd, "@Content", question.Content);

                    question.Id = (int)cmd.ExecuteScalar();
                }
            }
        }

        public void Update(Question question)
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE Question 
                            SET Content = @Content
                    
                        WHERE Id = @Id";

                    DbUtils.AddParameter(cmd, "@Content", question.Content);
                    DbUtils.AddParameter(cmd, "@Id", question.Id);

                    cmd.ExecuteNonQuery();
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
