using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Tag
    {
        public String tagName { get; set; }
        public String tagCode { get; set; }
        public String relatedTag { get; set; }

        SqlConnection conn = new SqlConnection(@"Server=tcp:wdr14.database.windows.net,1433;Initial Catalog=group;Persist Security Info=False;User ID=it19156798;Password=IT@19156798;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public String Insert(Tag t)
        {
            String st = "Erorr";
            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();

            try
            {
                String sql = "INSERT INTO Tag(TagName , TagCode , RelatedTag) VALUES (@TagName , @TagCode , @RelatedTag);";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TagName", t.tagName);
                cmd.Parameters.AddWithValue("@TagCode", t.tagCode);
                cmd.Parameters.AddWithValue("@RelatedTag", t.relatedTag);

                cmd.ExecuteNonQuery();

                st = "Success Insert";
            }
            catch (Exception ex)
            {
                st = ex.Message;

            }
            finally
            {
                conn.Close();
            }

            return st;

        }

        public String Update(Tag t , int id)
        {
            String st = "Erorr";
            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();

            try
            {

                String sql = "UPDATE Tag SET TagName=@TagName , TagCode=@TagCode , RelatedTag=@RelatedTag WHERE Id=@id;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@TagName", t.tagName);
                cmd.Parameters.AddWithValue("@TagCode", t.tagCode);
                cmd.Parameters.AddWithValue("@RelatedTag", t.relatedTag);

                cmd.ExecuteNonQuery();

                st = "Success Update";
            }
            catch (Exception ex)
            {
                st = ex.Message;

            }
            finally
            {
                conn.Close();
            }

            return st;

        }

    }
}
