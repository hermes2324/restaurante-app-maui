using Supabase;

namespace RestauranteNoseCual.Base_de_Datos
{
    public class Conexion
    {
        private static string url = Secretos.SupabaseUrl;
        private static string key = Secretos.SupabaseKey;

        private static Supabase.Client _supabase;

        public static Supabase.Client Supabase
        {
            get
            {
                if (_supabase == null)
                {
                    var options = new SupabaseOptions
                    {
                        AutoConnectRealtime = true
                    };
                    _supabase = new Supabase.Client(url, key, options);

                    Task.Run(async () => await _supabase.InitializeAsync()).Wait();
                }
                return _supabase;
            }
        }
    }
}
