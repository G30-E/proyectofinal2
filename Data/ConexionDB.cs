using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CattleHealthy_NET9_Final.Data
{
    public static class ConexionDB
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Server=USER-PC\\SQLEXPRESS01;Database=CattleHealthyDB;Trusted_Connection=True;");
            conn.Open();
            return conn;
        }

        // Guarda diagnóstico con foto en base de datos
        public static async Task SaveDiagnosticoFotoAsync(int bovinoId, byte[] imagenData, string analisisHF, string enfermedades, string causas, string tratamientos)
        {
            using (var conn = ObtenerConexion())
            {
                var cmd = new SqlCommand(@"
INSERT INTO DiagnosticosFoto (BovinoId, Fecha, Imagen, AnalisisHF, Enfermedades, Causas, Tratamientos)
VALUES (@bovinoId, GETDATE(), @imagen, @analisisHF, @enfermedades, @causas, @tratamientos)", conn);
                cmd.Parameters.AddWithValue("@bovinoId", bovinoId);
                cmd.Parameters.AddWithValue("@imagen", imagenData);
                cmd.Parameters.AddWithValue("@analisisHF", analisisHF);
                cmd.Parameters.AddWithValue("@enfermedades", enfermedades);
                cmd.Parameters.AddWithValue("@causas", causas);
                cmd.Parameters.AddWithValue("@tratamientos", tratamientos);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
